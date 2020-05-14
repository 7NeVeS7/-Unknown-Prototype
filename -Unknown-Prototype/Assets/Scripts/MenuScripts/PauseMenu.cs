using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused;
    [SerializeField]
    private GameObject _pauseMenuUI;
    private float _moving = 1f;
    private float _stop = 0f;

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseClick();    

        }   
    }
    public void PauseClick()
    {

        if (gameIsPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }
    public void Resume()
    {
        _pauseMenuUI.SetActive(false);
        Time.timeScale = _moving;
        gameIsPaused = false;
    }
    public void Pause()
    {
        _pauseMenuUI.SetActive(true);
        Time.timeScale = _stop;
        gameIsPaused = true;
    }
    public void MainMenu()
    {
        Time.timeScale = _moving;
        LevelManager.Instance.MainMenu();
    }
    public void Quit()
    {
        LevelManager.Instance.QuitGame();
    }
}
