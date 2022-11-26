using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerView : MonoBehaviour
{

    public void ButtonStart()
    {
        SceneManager.LoadScene("Game");
    }

    public void ButtonRestart() 
    {
        SceneManager.LoadScene("Game");
    }

    public void ButtonQuit() {
        Application.Quit();
    }
}
