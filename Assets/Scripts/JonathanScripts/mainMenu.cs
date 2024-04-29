using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("WTE_Dev 2");
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
