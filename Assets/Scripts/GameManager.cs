using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject WinUI;
    public GameObject LoseUI;
    public GameObject Spikes;

    public GameObject playerSpawner;

    private GameObject player;
    
    public bool winAnimHasEnded;

    bool Lost = false;
    bool Won = false;

    private SpikesScript spikesBruh;

    private void Awake()
    {

    }

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
        SpikesScript spikesBruh = Spikes.GetComponent<SpikesScript>();

        Won = true;

        if (Won && !Lost)
        {
            spikesBruh.TurnOffSpikes();

            WinUI.SetActive(true);
        }
    }

    public void Lose()
    {
        SpikesScript spikesBruh = Spikes.GetComponent<SpikesScript>();
        Lost = true;

        if (!Won && Lost)
        {
            spikesBruh.TurnOffSpikes();

            LoseUI.SetActive(true);
        }

    }

}
