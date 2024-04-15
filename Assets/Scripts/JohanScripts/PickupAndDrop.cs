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

    // Update is called once per frame
    private void Update()
    {
        // gör så att object kan plockas upp av spelaren
        if (Input.GetKeyDown(KeyCode.E))
        {
            ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            ShootRay();          
        }
        if (Input.GetKey(KeyCode.O))
        {
            grabbableObject.Rotate(0.3f);
        }
        if (Input.GetKey(KeyCode.P))
        {
            grabbableObject.Rotate(-0.3f);
        }
        //Behöver göra så att vid två olika knapp tryck sp roterar objectet vänster eller höger
    }
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
}