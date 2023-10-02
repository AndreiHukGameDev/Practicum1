using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Start");
    }
    public void SinglePlay()
    {
        SceneManager.LoadScene("SinglePlay");
    }
    public void MultiPlay()
    {
        SceneManager.LoadScene("MultiPlay");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
