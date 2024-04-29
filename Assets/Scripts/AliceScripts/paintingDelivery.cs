using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintingDelivery : MonoBehaviour
{
    public GameObject key;
    public bool puzzleCompleted;

    public void Start()
    {
        key = GameObject.FindGameObjectWithTag("key");
        key.SetActive(false);
        puzzleCompleted = false;
    }


    private void OnCollisionEnter(Collision collision)
    {
        //when object with tag crown collides with hand, the key will active and be visible
        if (collision.gameObject.tag == "crown")
        {
            key.SetActive(true);
            puzzleCompleted = true;
        }
    }
}
