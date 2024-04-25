using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class paintingDelivery : MonoBehaviour
{
    public GameObject key;

    public void Start()
    {
        key = GameObject.FindGameObjectWithTag("key");
        key.SetActive(false);
    }


    private void OnCollisionEnter(Collision collision)
    {
        //when object with tag crown collides with hand, the key will active and appear
        if (collision.gameObject.tag == "crown")
        {
            key.SetActive(true);
        }
    }
}
