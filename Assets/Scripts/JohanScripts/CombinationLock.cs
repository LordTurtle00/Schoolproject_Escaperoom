using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class CombinationLock : MonoBehaviour
{

    public GameObject[] AmountOfDials;
    public bool Answer = false;
    public int RightAnswers = 0;
    private bool IE = true;

    public bool puzzleCompleted = false;
    public GameObject lidOpen;
    public GameObject lidClosed;


    // Start is called before the first frame update
    void Start()
    {

        lidOpen.SetActive(false);
        lidClosed.SetActive(true);

        StartCoroutine(Check());

    }

    // Checks so that all the dials are in the right order
    public void RightCombination()
    {
        for (int i = 0; i < AmountOfDials.Length; i++)
        {
            Dials d = AmountOfDials[i].GetComponent<Dials>();
            if (d.Check == true)
            {
                RightAnswers++;
            }
            else
            {
                RightAnswers = 0;
            }
            
            if (RightAnswers == 7) {
                Answer = true;
            }
        }
        //Debug.Log(RightAnswers);
    }
    IEnumerator Check()
    {
        while (IE == true)
        {
            yield return new WaitForSeconds(1);
            for (int i = 0; i < AmountOfDials.Length; i++)
            {
                Dials d = AmountOfDials[i].GetComponent<Dials>();
                d.CheckRotation();
            }
            RightCombination();
            if (Answer == true)
            {
                StopCoroutine(Check());
                IE = false;

                puzzleCompleted = true;
                lidOpen.SetActive(true);
                lidClosed.SetActive(false);

            }
        }

    }
}