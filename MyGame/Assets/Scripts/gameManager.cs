using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public static bool gameIsPaused = false;
    bool gameended = false;
    private bool ismuted = false;

    [SerializeField] private GameObject GameOverMenuUI;
    [SerializeField] private GameObject WinMenuUI;
    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private GameObject infoMenuUI;


    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        infoMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Gameover()
    {
        if (gameended == false)
        {
            gameended = true;
            GameOverMenuUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void Winner()
    {
        if (gameended == false)
        {
            gameended = true;
            WinMenuUI.SetActive(true);
            Time.timeScale = 0f;
        }


    }

    public void Music()
    {
        ismuted = !ismuted;

        AudioListener.pause = ismuted;
        
    }

    public void info()
    {
        infoMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
}
