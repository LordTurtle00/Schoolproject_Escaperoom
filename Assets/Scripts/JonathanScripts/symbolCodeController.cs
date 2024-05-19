using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class symbolCodeController : MonoBehaviour
{
    //Defining and finding the Dials and Door gameobjects
    public Transform dial1, dial2, dial3, dial4, dial5, dial6, dial7;
    public GameObject closedLid, openLid;
    void Start()
    {
        dial1 = transform.Find("Dial1");
        dial2 = transform.Find("Dial2");
        dial3 = transform.Find("Dial3");
        dial4 = transform.Find("Dial4");
        dial5 = transform.Find("Dial5");
        dial6 = transform.Find("Dial6");
        dial7 = transform.Find("Dial7");
        closedLid.SetActive(true);
        openLid.SetActive(false);
    }

    void Update()
    {
        if (dial1.GetComponent<symbolDials>().dialPos == 1 &&
            dial2.GetComponent<symbolDials>().dialPos == 3 &&
            dial3.GetComponent<symbolDials>().dialPos == 2 &&
            dial4.GetComponent<symbolDials>().dialPos == 1 &&
            dial5.GetComponent<symbolDials>().dialPos == 4 &&
            dial6.GetComponent<symbolDials>().dialPos == 4 &&
            dial7.GetComponent<symbolDials>().dialPos == 2)
        {
            //The chest opens when thecorrect combination is inputted
            closedLid.SetActive(false);
            openLid.SetActive(true);
        }
    }
}
