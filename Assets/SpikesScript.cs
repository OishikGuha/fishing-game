using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesScript : MonoBehaviour
{

    private GameObject[] spikes;

    private int spikesInt;

    // Start is called before the first frame update
    void Start()
    {
        spikesInt = spikes.Length;
    }

    public void TurnOffSpikes()
    {
        for (int x = 0; x < spikesInt; x++)
        {
            Collider2D spikeCollider = spikes[x].GetComponent<Collider2D>();

            spikeCollider.enabled = false;
        }
    }
}
