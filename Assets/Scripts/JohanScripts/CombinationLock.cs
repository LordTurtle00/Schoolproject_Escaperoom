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
        
        
    }

    // Update is called once per frame
    public void RightCobination()
    {
      //Dials d = gameObject.GetComponent<Dials>();
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
    IEnumerator check()
    {
        yield return new WaitForSeconds(1);
    }
    private void Update()
    {
        // Use Ienumerator to make so that in the update function the update happens every second insted of every frame
        // Move the CheckRotation function from PickupAndDrop to this update function so that the rotation of the dials are checked every few seconds
        // Same with the RightCobination funktion move it to this update function to check every few seconds that the combination of the lock is correct

        

    }
}
