using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class CombinationLock : MonoBehaviour
{

    public GameObject[] AmountOfDials;
    public bool Answer = false;
    public int RightAnswers = 0;


    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Check());

    }

    // Checks so that all the dials are in the right order
    public void RightCobination()
    {
      for ( int i = 0; i < AmountOfDials.Length; i++)
        {
           Dials d = AmountOfDials[i].GetComponent<Dials>();
           if( d.Check == true)
            {
                RightAnswers++;
                continue;
               
            }
           if( d.Check == false)
            {
                RightAnswers = 0;
                break;
                
            }

        }
      if (RightAnswers == 7)
        {
            Answer = true;
            Debug.Log("Nice");
        }
    }
    IEnumerator Check()
    {
        yield return new WaitForSeconds(1);
        for (int i = 0; i<AmountOfDials.Length; i++)
        {
            Dials d = AmountOfDials[i].GetComponent<Dials>();
            d.CheckRotation();
            
        }
        RightCobination();

    }
private void Update()
    {
        // Use Ienumerator to make so that in the update function the update happens every second insted of every frame
        // Move the CheckRotation function from PickupAndDrop to this update function so that the rotation of the dials are checked every few seconds
        // Same with the RightCobination funktion move it to this update function to check every few seconds that the combination of the lock is correct
        if (Answer == false)
        {
            
            StartCoroutine(Check());
            Debug.Log("working?");
        }


        if (Answer == true)
        {
            StopCoroutine(Check());
            Debug.Log("Plz Stop");
        }
        

    }
}
