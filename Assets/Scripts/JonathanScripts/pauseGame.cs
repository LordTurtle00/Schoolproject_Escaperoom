using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseGame : MonoBehaviour
{
    //Finds the pause panel
    public GameObject PausePanel;
    [SerializeField] GameObject cam;

    private void Update()
    {
        //When pressing V, the pause panel activates, allowing th player to select various options.
        //Time stops in-game and you can use your mouse.
        if (Input.GetKeyDown(KeyCode.V))
        {
            PausePanel.SetActive(true);
            Time.timeScale = 0;

            cam.GetComponent<CameraController>().Sensitivity = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

}
