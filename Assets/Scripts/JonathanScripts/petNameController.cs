using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class petNameController : MonoBehaviour
{
    //Defining and finding the Dials and Door gameobjects
    public Transform dial1, dial2, dial3, dial4, dial5, dial6, dial7;
    public GameObject movingObj;
    void Start()
    {
        dial1 = transform.Find("pCylinder1");
        dial2 = transform.Find("pCylinder2");
        dial3 = transform.Find("pCylinder3");
        dial4 = transform.Find("pCylinder4");
        dial5 = transform.Find("pCylinder5");
        dial6 = transform.Find("pCylinder6");
        dial7 = transform.Find("pCylinder7");
        movingObj = GameObject.Find("petPuzzleMove");
        
    }

    // Update 
    void Update()
    {
        if (dial1.GetComponent<petNameDial>().dialPos == 4 &&
            dial2.GetComponent<petNameDial>().dialPos == 3 &&
            dial3.GetComponent<petNameDial>().dialPos == 2 &&
            dial4.GetComponent<petNameDial>().dialPos == 4 &&
            dial5.GetComponent<petNameDial>().dialPos == 3 &&
            dial6.GetComponent<petNameDial>().dialPos == 3 &&
            dial7.GetComponent<petNameDial>().dialPos == 2)
        {
            //d�rren f�rsvinner d� r�tt kombination skickas in
            movingObj.transform.TransformDirection(0.0f, 0.0f, 3.0f);
        }
    }
}
