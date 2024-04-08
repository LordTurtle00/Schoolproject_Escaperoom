using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    [SerializeField] private Transform PlayerCameraTransform;
    [SerializeField] private LayerMask PickUpLayerMask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // g�r s� att object kan plockas upp av spelaren
        if (Input.GetKeyDown(KeyCode.E))
        {
            float PickupDistance = 2f;
            if (Physics.Raycast(PlayerCameraTransform.position, PlayerCameraTransform.forward, out RaycastHit raycastHit, PickupDistance, PickUpLayerMask)) {
                Debug.Log(raycastHit.transform);
            }
        }
        // G�r s� att object som har plockats upp sparas i en lista som spelaren kan g� igenom

        //skapa et UI som vissar en bild av objectet p� sk�rmen
    }
}
