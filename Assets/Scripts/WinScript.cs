using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{

    public GameManager gm;

    public void WinAnimHasEnded()
    {
        gm.winAnimHasEnded = true;
        Debug.Log("yes");
    }

}
