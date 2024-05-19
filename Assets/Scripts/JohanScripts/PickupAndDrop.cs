using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupAndDrop: MonoBehaviour
{
    Ray ray;
    [SerializeField] private Transform PlayerCameraTransform;
    [SerializeField] private Transform GrabPointTransform;
    [SerializeField] private LayerMask PickUpLayerMask;

    private GrabbableObject grabbableObject;
    public GameObject hitDial;
   

    // Shots out a ray from a point on the screen and also makes the objects if they have GrabbableObject script on them rotateable
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            ShootRay();
            rayHitDials();
            LockRay();
        }
        if (Input.GetKey(KeyCode.O))
        {
            grabbableObject.Rotate(0.3f);
        }
        if (Input.GetKey(KeyCode.P))
        {
            grabbableObject.Rotate(-0.3f);
        }
       
       

    }
   
    // This function makes it so that the player can pick up gameobjects with the GrabbableObject script atached and drop them 
    void ShootRay()
    {
        if (grabbableObject == null)
        {
            float PickupDistance = 2f;
            if (Physics.Raycast(PlayerCameraTransform.position, PlayerCameraTransform.forward, out RaycastHit raycastHit, PickupDistance, PickUpLayerMask))
            {

                if (raycastHit.transform.TryGetComponent(out grabbableObject))
                {
                    grabbableObject.Grab(GrabPointTransform);
                }
            }
        }
        else
        {
            grabbableObject.Drop();
            grabbableObject = null;
        }

    }

    void rayHitDials()
    {
        if (Physics.Raycast(ray, out RaycastHit hitInfo, 10f))
        {
            if (hitInfo.collider.gameObject.CompareTag("petDial"))
            {
                hitDial = hitInfo.collider.gameObject;
                hitDial.GetComponent<petNameDial>().dialPos += 1;
                if (hitDial.GetComponent<petNameDial>().dialPos == 5)
                {
                    hitDial.transform.Rotate(-90.0f, 0.0f, 0.0f, Space.World);
                    hitDial.GetComponent<petNameDial>().dialPos = 1;
                }
                else
                {
                    hitDial.transform.Rotate(-90.0f, 0.0f, 0.0f, Space.World);
                }
            }
        }
    }
    // Rotates the dils of the code locks in the game
    void LockRay()
    {
        float interact = 2f;
        if (Physics.Raycast(PlayerCameraTransform.position, PlayerCameraTransform.forward, out RaycastHit raycastHit, interact, PickUpLayerMask))
        {
            Dials d = raycastHit.collider.GetComponent<Dials>();
            if(d != null)
            {
                d.DialRotate();
            }
        }
    }
}