using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableObject : MonoBehaviour
{
    private Rigidbody rb;
    private Transform GrabPointTransform;
    // Checks so that the component has a rigidbodycomponent atached
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Sets the gravity of the object to false so that the player can pick up and move objects and 
    public void Grab(Transform GrabPointTransform)
    {
        this.GrabPointTransform = GrabPointTransform;
        rb.useGravity = false;
    }
    //Sets the gravity of the object to true so that the player drops the object
    public void Drop()
    {
        
        this.GrabPointTransform = null;
        rb.useGravity = true;        
    }
    // Sets a new vector on the object so that the player can rotate the object
    public void Rotate(float dir)
    {
        transform.Rotate(new Vector3(0, dir, 0));
    }
    // Makes the picked up object move towards an empty object infront of the player so that the player can move with the object
    private void FixedUpdate() { 
     
       if (GrabPointTransform != null) { 
           rb.MovePosition(GrabPointTransform.position);
       }
    }
}
