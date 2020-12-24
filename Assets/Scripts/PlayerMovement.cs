using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;

    public Vector2 pushLeft;
    public Vector2 pushRight;

    private bool facingRight = false;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            rb.AddForce(pushLeft * 10 * Time.deltaTime);
            animator.SetBool("flipped", false);
        }
        if (Input.GetKeyDown("d"))
        {
            rb.AddForce(pushRight * 10 * Time.deltaTime);
            animator.SetBool("flipped", true);
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
