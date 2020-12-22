using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject WinUI;

    public GameObject playerSpawner;

    private GameObject player;
    
    public bool winAnimHasEnded;

    private void Start()
    {
        player = playerSpawner.GetComponent<PlayerSpawn>().player;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Win()
    {
        if (winAnimHasEnded == true)
        {

        }
        WinUI.SetActive(true);
        Debug.Log(winAnimHasEnded);

    }

    public void PushLeft()
    {

    }

}
