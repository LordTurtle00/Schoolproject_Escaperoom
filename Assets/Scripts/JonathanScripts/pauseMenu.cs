using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    [SerializeField] GameObject cam;
    public void Continue()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
        cam.GetComponent<CameraController>().Sensitivity = 2;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
