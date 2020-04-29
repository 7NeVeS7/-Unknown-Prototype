using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoSingleton<LevelManager>
{
    public void Dead()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
