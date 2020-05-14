using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoSingleton<LevelManager>
{
    private int lvl = 1;
    private int menu = 0;

    public void FirstLevel()
    {
        SceneManager.LoadScene(lvl, LoadSceneMode.Single); ; //zmienić na indeksy
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(menu, LoadSceneMode.Single);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    

}
