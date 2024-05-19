using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        //When PlayGame() is called (happens when the "Play" button is clicked), the game is loaded.
        SceneManager.LoadScene("BMB_FinalScene");
    }
    public void QuitApplication()
    {
        //When QuitApplication() is called (happens when the "Quit" button is clicked), the game closes.
        Application.Quit();
    }
}
