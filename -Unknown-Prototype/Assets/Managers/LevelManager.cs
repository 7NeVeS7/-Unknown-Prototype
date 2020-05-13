using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoSingleton<LevelManager>
{
    public void FirstLevel()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single); //zmienić na indeksy
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    

}
