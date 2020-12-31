using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    public GameManager gm;

    public PlayerSpawn playerSpawn;

    private GameObject passableObj;

    public string color;

    [HideInInspector]
    public string colorName;

    [HideInInspector]
    public string randomName;

    // Start is called before the first frame update
    void Start()
    {
        passableObj = playerSpawn.player;
        randomName = playerSpawn.randomPlayerName();
        colorName = randomName;
        Debug.Log(colorName + " " + randomName);

        randomName = string.Format("{0}(Clone)", randomName);
        Debug.Log(randomName);

    }

    private void Update()
    {

        if (randomName == "(Clone)(Clone)")
        {
            randomName = "Player_c(Clone)";
        }

        if(color == "green")
            randomName = "Player_g(Clone)";
        else if (color == "blue")
            randomName = "Player_c(Clone)";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == randomName)
        {
            gm.Win();
        }
    }
}
