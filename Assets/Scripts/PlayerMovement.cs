using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;

    public Vector2 pushLeft;
    public Vector2 pushRight;
    
    public Animator animator;

    private Button Rbutton;
    private Button Lbutton;

    private PlayerSpawn spawner;

    // Start is called before the first frame update
    void Start()
    {
        spawner = FindObjectOfType<PlayerSpawn>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        Rbutton = spawner.rButton;
        Lbutton = spawner.lButton;

        Debug.Log(animator);

    }

    // Update is called once per frame
    void FixedUpdate()
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

        Rbutton.onClick.AddListener(PushRight);
        Lbutton.onClick.AddListener(PushLeft);

    }

    public void PushLeft()
    {
        rb.AddForce(pushLeft * Time.deltaTime);
        animator.SetBool("flipped", false);
    }

    public void PushRight()
    {
        rb.AddForce(pushRight * Time.deltaTime);
        animator.SetBool("flipped", true);
    }

    public Animator GetAnimator(Animator animatorF)
    {
        return animatorF = animator;
    }
}
