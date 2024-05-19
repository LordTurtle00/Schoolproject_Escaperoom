using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float Speed = 10f;
    [SerializeField] private float Gravity = -9.81f;
    private CharacterController characterController;
    public bool canMove = true;

    private void Start()
    {
        characterController = gameObject.GetComponent<CharacterController>();
    }

    private void Update()
    {
        //The code below controls the speed and direction fo the player character's movement.
        float xAxis = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        float zAxis = Input.GetAxis("Vertical") * Speed * Time.deltaTime;
        Vector3 moveDirection = new Vector3(xAxis, 0f, zAxis);
        moveDirection = transform.TransformDirection(moveDirection);

        float yVelocity = Gravity * Time.deltaTime;
        moveDirection.y = yVelocity;

        characterController.Move(moveDirection);
    }
}
