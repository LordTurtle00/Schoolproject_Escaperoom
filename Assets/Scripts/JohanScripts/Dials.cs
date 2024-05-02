using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;


public class Dials : MonoBehaviour
{
    private int DialIndex;
    public Vector3  Correctrotation;
    public GameObject Dial;   
    public bool Check = false;
    

    //When the game starts it randomizes the rotation value of the dials of the lock
    void Start()
    {
        DialIndex = Random.Range(0, 10);
        transform.Rotate (new Vector3(0, DialIndex * 90, 0));
        
    }
    //rotates the object with a specified value
    public void DialRotate(float dirc)
    {
        transform.Rotate(new Vector3(0, dirc, 0));

     
    }
    // Checks so that the rotation of the dial is the correct rotation to open the lock
    public void CheckRotation()
    {
        Vector3 dialRot = Dial.transform.rotation.eulerAngles;
        if((int)Correctrotation.x == (int)dialRot.x)
        {                     
            Check = true;
        }
        else
        {
            Check = false;
        }
       
    }
 
}
