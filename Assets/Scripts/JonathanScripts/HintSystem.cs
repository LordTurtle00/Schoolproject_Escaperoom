using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HintSystem : MonoBehaviour
{
    public GameObject Player, Candles, table;
    public TextMeshProUGUI hint;
    private clockPuzzle pClock;
    private CandleController pCandle;
    private weightPuzzle pWeight;

    void Start()
    {
        hint.enabled = false;
        Player = GameObject.FindGameObjectWithTag("Player");
        pClock = Player.GetComponent<clockPuzzle>();
        pCandle = Candles.GetComponent<CandleController>();
        pWeight = table.GetComponent<weightPuzzle>();


    }

    // Update is called once per frame
    void Update()
    {
        if (!pClock.puzzleCompleted)
        {
            hint.text = "Check the time; Do not delay! These clocks move backwards, look closely, I say!";
        }
        else if(pClock.puzzleCompleted && !pCandle.isComplete)
        {
            hint.text = "The wand of fire is the work of the Devil! You must light the right candles to find the next level!";
        }
        /*else if (pClock.puzzleCompleted && pCandle.isComplete && pWeight)
        {
            hint.text = "PLACEHOLDERHINT FOR WEIGHT PUZZLE";
        }*/
        




        if (Input.GetKeyDown(KeyCode.H))
        {
            if (!hint.enabled)
            {
                hint.enabled = true;
            }else
            {
                hint.enabled = false;
            }
        }
    }
}
