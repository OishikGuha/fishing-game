using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesScript : MonoBehaviour
{

    public GameObject[] spikes;

    public void TurnOffSpikes()
    {
        for (int x = 0; x < spikes.Length; x++)
        {
            Collider2D spikeCollider = spikes[x].GetComponent<Collider2D>();

            spikeCollider.enabled = false;
        }
    }
}
