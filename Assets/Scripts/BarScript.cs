using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarScript : MonoBehaviour
{
    Collider2D objCollider = new Collider2D();

    public Sprite greenBar;
    public Sprite blueBar;

    public bool invertColors;

    public GameManager gm;

    private string color = "blue";
    private string playerName;

    public GameObject player;

    public bool switchColors = false;

    private void Update()
    {
        if (invertColors == false)
        {
            if (switchColors)
            {
                SwitchColors("green");
            }
            else
            {
                SwitchColors("blue");
            }
        }
        else if (invertColors)
        {
            if (switchColors)
            {
                SwitchColors("green");
            }
            else
            {
                SwitchColors("blue");
            }
        }
    }

    public void SwitchColors(string color)
    {
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
       
        if (color == "green")
        {
            sr.sprite = greenBar;
            gameObject.layer = LayerMask.NameToLayer("Green_bar");
        }
        else if (color == "blue")
        {
            sr.sprite = blueBar;
            gameObject.layer = LayerMask.NameToLayer("Blue_bar");
        }
    }
}
