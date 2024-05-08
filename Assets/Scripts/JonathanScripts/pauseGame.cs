using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseGame : MonoBehaviour
{
    public GameObject PausePanel;
    [SerializeField] GameObject cam;

    private void Update()
    {
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
