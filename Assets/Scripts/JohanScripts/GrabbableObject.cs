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
        rb.isKinematic = true;
    }

    public void Drop()
    {
        
        this.GrabPointTransform = null;
        rb.isKinematic = false;
    }

    private void FixedUpdate() { 
     
       if (GrabPointTransform != null) { 
           rb.MovePosition(GrabPointTransform.position);
       }
    }
}
