using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Player;
    [SerializeField] float Sensitivity = 2f;
    float CamVertRot = 0f;
    void Start()
    {
        //Removes and locks the mouse cursor to the middle of the screen.
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        //The code below allows for rotation of the camera
        float inputX = Input.GetAxis("Mouse X") * Sensitivity;
        float inputY = Input.GetAxis("Mouse Y") * Sensitivity;

        CamVertRot -= inputY;
        CamVertRot = Mathf.Clamp(CamVertRot, -90f, 90f);
        transform.localEulerAngles = Vector3.right * CamVertRot;

        Player.Rotate(Vector3.up * inputX);

    }
}