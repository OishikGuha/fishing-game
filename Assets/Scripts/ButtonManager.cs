using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{

    public PlayerSpawn spawn;

    private PlayerMovement player;
    private Animator playerAnimator;

    // Start is called before the first frame update
    void Start()
    {
        player = spawn.player.GetComponent<PlayerMovement>();
        playerAnimator = spawn.player.GetComponent<Animator>();

        if (player == null)
        {
            Debug.LogError("Bruh");
        }

    }

    public void PushLeft()
    {
        player.PushLeft();
        playerAnimator.SetBool("flipped", false);
    }

    public void PushRight()
    {
        player.PushRight();
        playerAnimator.SetBool("flipped", true);
    }

}
