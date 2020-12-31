using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{

    public BarScript bar;
    public LineRenderer wire;

    public Animator buttonAnimator;

    private GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        Physics2D.queriesStartInColliders = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position, bar.transform.position, Color.green);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(bar.invertColors == false)
            {
                buttonAnimator.SetBool("pressed", true);
                bar.switchColors = true;
            }
            else if (bar.invertColors)
            {
                buttonAnimator.SetBool("pressed", true);
                bar.switchColors = false;
            }
        }
    }

}
