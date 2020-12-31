using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameManager gm;

    private Transform player1;
    private Transform player2;

    private Camera cam;

    private float minzoom = 5f;
    private float maxzoom = 50;

    private List<Transform> targets = new List<Transform>(1);

    private void Start()
    {
        cam = GetComponent<Camera>();

        Debug.Log(targets.Count);

        player1 = gm.player.transform;
        player2 = GameObject.Find("Player_c(Clone)").transform;

        targets.Add(player1);
        targets.Add(player2);

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 center = GetCenterPoint();
        transform.position = center - new Vector3(0f, 0f, 1f);
        Zoom();
    }

    void Zoom()
    {
        float newZoom = Mathf.Lerp(minzoom, maxzoom, GetGreatestDistance() / 50f);
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, newZoom, Time.deltaTime);
    }

    float GetGreatestDistance()
    {
        var bounds = new Bounds(targets[0].position, Vector3.zero);
        for(int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }

        return bounds.size.x;
    }

    Vector3 GetCenterPoint()
    {
        if(targets.Count == 1)
        {
            return targets[0].position;
        }

        var bounds = new Bounds(targets[0].position, Vector3.zero);
        for(int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }
        return bounds.center;
    }
}
