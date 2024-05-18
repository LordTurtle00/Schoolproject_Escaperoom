using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonController : MonoBehaviour
{
    public GameObject Player;
    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.GetComponent<clockPuzzle>().buttonPressed)
        {
            print("knapp tryckt");
            animator.SetBool("buttonPressed", true);
        }
    }
}
