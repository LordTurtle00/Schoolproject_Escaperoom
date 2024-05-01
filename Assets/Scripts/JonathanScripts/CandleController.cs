using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleController : MonoBehaviour
{
    //Defining all the candles, the key thats spawns, the partice system and completion variables
    [SerializeField] GameObject candle1, candle2, candle3, candle4, candle5;
    public CandleActivation CA;
    [SerializeField] GameObject DoorKey1;
    public ParticleSystem ps;
    public bool isComplete = false;

    void Start()
    {
        //The key is hidden at the start. The rest of the code specifies which candles are which
        DoorKey1.SetActive(false);
        candle1 = gameObject.transform.GetChild(4).gameObject;
        candle2 = gameObject.transform.GetChild(3).gameObject;
        candle3 = gameObject.transform.GetChild(2).gameObject;
        candle4 = gameObject.transform.GetChild(1).gameObject;
        candle5 = gameObject.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //The following if-statement is the one (and only) solution of lit candles that completes the puzzle
        if (candle1.GetComponent<CandleActivation>().isLit == false &&
            candle2.GetComponent<CandleActivation>().isLit == true &&
            candle3.GetComponent<CandleActivation>().isLit == true &&
            candle4.GetComponent<CandleActivation>().isLit == false &&
            candle5.GetComponent<CandleActivation>().isLit == true)
        {
            //When the puzzle is completed, the key is revealed, while stopping the rotation of the inner circle.
            //Also marks the puzzle as complete via the isComplete variable
            DoorKey1.SetActive(true);
            var rot = ps.rotationOverLifetime;
            isComplete = true;
            rot.z = 0;
        }
    }
}
