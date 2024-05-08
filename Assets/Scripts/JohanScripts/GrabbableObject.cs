using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableObject : MonoBehaviour
{
    private Rigidbody rb;
    private Transform GrabPointTransform;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Grab(Transform GrabPointTransform)
    {
        this.GrabPointTransform = GrabPointTransform;
        rb.useGravity = false;
        //rb.isKinematic = true;
    }

    public void Drop()
    {
        
        this.GrabPointTransform = null;
        rb.useGravity = true;
        //rb.isKinematic = false;
    }

    public void Rotate(float dir)
    {
        transform.Rotate(new Vector3(0, dir, 0));
    }

    private void FixedUpdate() { 
     
       if (GrabPointTransform != null) { 
           rb.MovePosition(GrabPointTransform.position);
       }
    }
}
