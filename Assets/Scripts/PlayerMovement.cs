using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;

    public Vector2 pushLeft;
    public Vector2 pushRight;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            rb.AddForce(pushLeft * Time.deltaTime);

        }
        if (Input.GetKeyDown("d"))
        {
            rb.AddForce(pushRight * Time.deltaTime);

        }
    }

    public void PushLeft()
    {
        rb.AddForce(pushLeft * Time.deltaTime);
    }

    public void PushRight()
    {
        rb.AddForce(pushRight * Time.deltaTime);
    }

}
