using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class winGame : MonoBehaviour
{
    public GameObject key;
    [SerializeField] GameObject cam;
    public GameObject winPanel;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == key)
        {
            winPanel.SetActive(true);
            Time.timeScale = 0;
            cam.GetComponent<CameraController>().Sensitivity = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }
    }
}
