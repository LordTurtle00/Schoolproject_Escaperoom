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
    private CobinationLock combinationLock;

    // Update is called once per frame
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            ShootRay();
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
   
    // g�r s� att object kan plockas upp av spelaren
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
    void LockRay()
    {
        float interact = 2f;
        if (Physics.Raycast(PlayerCameraTransform.position, PlayerCameraTransform.forward, out RaycastHit raycastHit, interact, PickUpLayerMask))
        {
            if (raycastHit.transform.TryGetComponent(out combinationLock))
            {
                combinationLock.LockRotate(58f);
            }
        }
    }
}