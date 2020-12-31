using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSpawn : MonoBehaviour
{

    public GameObject[] playerPrefabs;

    public Button rButton;
    public Button lButton;

    [HideInInspector]
    public GameObject player;

    [HideInInspector]
    public PlayerMovement playerMovement;

    public GameObject[] spawnPoints;

    private int randomInt;
    private int randomIntPlayer;

    // Start is called before the first frame update
    void Awake()
    {

        for (int x = 0; x < playerPrefabs.Length; x++)
        {
            randomInt = Random.Range(0, spawnPoints.Length);
            randomInt = Random.Range(0, playerPrefabs.Length);

            player = Instantiate(playerPrefabs[x], spawnPoints[randomInt].transform.position, Quaternion.identity);
            playerMovement = player.GetComponent<PlayerMovement>();

        }
    }

    public string randomPlayerName()
    {
        return playerPrefabs[randomInt].name;
    }

    public void PushLeft()
    {        
        playerMovement.PushLeft();      
    }
}
