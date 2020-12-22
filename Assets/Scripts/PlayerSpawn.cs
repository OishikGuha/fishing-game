using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{

    public GameObject playerPrefab;

    [HideInInspector]
    public GameObject player;

    public GameObject[] spawnPoints;

    private int randomInt;

    // Start is called before the first frame update
    void Start()
    {
        randomInt = Random.Range(0, spawnPoints.Length);

        player = Instantiate(playerPrefab, spawnPoints[randomInt].transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
