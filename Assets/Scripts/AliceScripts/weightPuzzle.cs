using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weightPuzzle : MonoBehaviour
{
    public bool puzzleCompleted = false;
    public GameObject key;

    bool weight2kg = false;
    bool weight4kg = false;
    bool weight4kg_1 = false;
    bool weight7kg = false;
    bool weight8kg = false;

    public void Start()
    {
        key = GameObject.Find("DoorKey (1)");
        key.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Checks when object collides with weight
        if (collision.gameObject.name == "2kg")
        {
            weight2kg = true;
        }
        else if (collision.gameObject.name == "4kg")
        {
            weight4kg = true;
        }
        else if (collision.gameObject.name == "4kg_1")
        {
            weight4kg_1 = true;
        }
        else if (collision.gameObject.name == "7kg")
        {
            weight7kg = true;
        }
        else if (collision.gameObject.name == "8kg")
        {
            weight8kg = true;
        }

        //When all the correct weight are on, puzzle gets completed
        if (weight4kg == true &&
            weight4kg_1 ==true &&
            weight7kg == true &&
            weight2kg == false &&
            weight8kg == false)
        {
            Debug.Log("PUZZLE COMPLETED");
            key.SetActive(true);
            puzzleCompleted = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        //Checks when object stops colliding with weight
        if (collision.gameObject.name == "2kg")
        {
            weight2kg = false;
        }
        else if (collision.gameObject.name == "4kg")
        {
            weight4kg = false;
        }
        else if (collision.gameObject.name == "4kg_1")
        {
            weight4kg_1 = false;
        }
        else if (collision.gameObject.name == "7kg")
        {
            weight7kg = false;
        }
        else if (collision.gameObject.name == "8kg")
        {
            weight8kg = false;
        }
        if (weight4kg == true &&
               weight4kg_1 == true &&
               weight7kg == true &&
               weight2kg == false &&
               weight8kg == false)
        {
            key.SetActive(true);
            puzzleCompleted = true;
            
        }
    }
}
