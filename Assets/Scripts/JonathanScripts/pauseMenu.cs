using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{   
    //This script dictates the logic of the buttons in teh pause menu.
    public GameObject PausePanel;
    [SerializeField] GameObject cam;

    //When a button calls the Continue function, the game time continues as normal
    public void Continue()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
        cam.GetComponent<CameraController>().Sensitivity = 2;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    //When a button calls the QuitGame function, the game closes
    public void QuitGame()
    {
        Application.Quit();
    }
    //When a button calls the RestartLevel function, the scene is reloaded from the start
    public void RestartLevel()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
        cam.GetComponent<CameraController>().Sensitivity = 2;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene("WTE_Jonathan");
    }
}
