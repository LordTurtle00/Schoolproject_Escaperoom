using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour
{
    public GameObject key;
    public GameObject door;
    private void Start()
    {
        //Find the door and key objects
        door = gameObject;
        key = GameObject.FindWithTag("key");
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Disables the key and door, allowing passage through
        if (collision.gameObject == key)
        {
            key.SetActive(false);
            door.SetActive(false);
        }
    }
}
