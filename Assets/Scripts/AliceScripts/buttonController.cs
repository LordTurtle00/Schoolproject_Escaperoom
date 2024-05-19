using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonController : MonoBehaviour
{
    public GameObject Player;
    [SerializeField] private Animator animator1;
    [SerializeField] private Animator animator2;
    [SerializeField] private Animator animator3;
    [SerializeField] private Animator animator4;

    private void buttonCheck()
    {
        if (Player.GetComponent<clockPuzzle>().player_buttonPressed1)
        {
            animator1.SetBool("buttonPressed1", true);
        }
        else if (!Player.GetComponent<clockPuzzle>().player_buttonPressed1)
        {
            animator1.SetBool("buttonPressed1", false);
        }


        if (Player.GetComponent<clockPuzzle>().player_buttonPressed2)
        {
            animator2.SetBool("buttonPressed2", true);
        }
        else if (!Player.GetComponent<clockPuzzle>().player_buttonPressed2)
        {
            animator2.SetBool("buttonPressed2", false);
        }

        if (Player.GetComponent<clockPuzzle>().player_buttonPressed3)
        {
            animator3.SetBool("buttonPressed3", true);
        }
        else if (!Player.GetComponent<clockPuzzle>().player_buttonPressed3)
        {
            animator3.SetBool("buttonPressed3", false);
        }


        if (Player.GetComponent<clockPuzzle>().player_buttonPressed4)
        {
            animator4.SetBool("buttonPressed4", true);
        }
        else if (!Player.GetComponent<clockPuzzle>().player_buttonPressed4)
        {
            animator4.SetBool("buttonPressed4", false);
        }
    }

    void Update()
    {
        buttonCheck();
    }
}
