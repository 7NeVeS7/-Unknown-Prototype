using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        LevelManager.Instance.FirstLevel();
    }
    public void QuitButton()
    {
        LevelManager.Instance.QuitGame();
    }
}
