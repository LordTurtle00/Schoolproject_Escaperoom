using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class winGame : MonoBehaviour
{
    //Finds the key that allows you to with the game
    public GameObject key;
    [SerializeField] GameObject cam;
    public GameObject winPanel;

    private void OnCollisionEnter(Collision collision)
    {
        //Checks if the they collides with the gameObject
        if (collision.gameObject == key)
        {
            //Activates the win panel, allowing the player to select "restart" or "return to the main menu".
            //Time stops and the player can use their mouse.
            winPanel.SetActive(true);
            Time.timeScale = 0;
            cam.GetComponent<CameraController>().Sensitivity = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }
    }
    public void winRestart()
    {
        Time.timeScale = 1;
        cam.GetComponent<CameraController>().Sensitivity = 2;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene("BMB_FinalScene");
    }
    public void returnToMenu()
    {
        Time.timeScale = 1;
        cam.GetComponent<CameraController>().Sensitivity = 2;
        SceneManager.LoadScene("WTE_Menu");
    }
    public void winExit()
    {
        Application.Quit();
    }

}
