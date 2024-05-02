using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintingDelivery : MonoBehaviour
{
    public GameObject key;
    public GameObject leftHand;
    public bool puzzleCompleted = false;

    public void Start()
    {
        key = GameObject.Find("DoorKey2");
        key.SetActive(false);

        leftHand = GameObject.Find("leftHand");
        leftHand.SetActive(false);
    }


    private void OnCollisionEnter(Collision collision)
    {
        //when object with tag crown collides with hand, the key will active and be visible
        if (collision.gameObject.tag == "orb")
        {
            key.SetActive(true);
            leftHand.SetActive(true);

            puzzleCompleted = true;
        }
    }
}
