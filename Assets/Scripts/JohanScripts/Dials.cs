using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;


public class Dials : MonoBehaviour
{
    private int DialIndex;
    public int CorrectRotation;
    public GameObject Dial;   
    public bool Check = false;

    //When the game starts it randomizes the rotation value of the dials of the lock
    void Start()
    {
        DialIndex = Random.Range(0, 4);
        var rot = (DialIndex * 90) + 15 - 180;
        transform.rotation = Quaternion.Euler(rot, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
    }
    //rotates the object with a specified value
    public void DialRotate()
    {
        transform.Rotate(new Vector3(0, 90, 0));
    }
    // Checks so that the rotation of the dial is the correct rotation to open the lock
    public void CheckRotation()
    {
        // fråga inte det är unity som är blä, usch..
        float dialRot = Dial.transform.localRotation.eulerAngles.x;
        dialRot = Mathf.FloorToInt(dialRot);
        if (dialRot > 180)
        {
            dialRot -= 360;
        }
        if (CorrectRotation == dialRot)
        {
            Check = true;
        }
        else
        {
            Check = false;
        }
       
    }
 
}
