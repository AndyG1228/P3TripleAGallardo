using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject pauseScreen;
    private bool paused;
    public GameObject titleScreen;
    public Button buttonRestart;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            ChangePaused();
        }
    }

    public void StartGame()
    {
        titleScreen.gameObject.SetActive(false);
        Time.timeScale = 1;
        
    }

    void ChangePaused()
    {
        if (!paused)
        {
            paused = true;
            pauseScreen.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            paused = false;
            pauseScreen.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void gameRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        buttonRestart.gameObject.SetActive(true);
    }

}
