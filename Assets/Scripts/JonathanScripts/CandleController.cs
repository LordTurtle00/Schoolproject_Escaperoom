using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleController : MonoBehaviour
{
    [SerializeField] GameObject candle1, candle2, candle3, candle4, candle5;
    public CandleActivation CA;

    void Start()
    {
        candle1 = gameObject.transform.GetChild(1).gameObject;
        candle2 = gameObject.transform.GetChild(2).gameObject;
        candle3 = gameObject.transform.GetChild(3).gameObject;
        candle4 = gameObject.transform.GetChild(4).gameObject;
        candle5 = gameObject.transform.GetChild(5).gameObject;

        Debug.Log(candle1);
    }

    // Update is called once per frame
    void Update()
    {
        if (candle1.GetComponent<CandleActivation>().isLit == false &&
            candle2.GetComponent<CandleActivation>().isLit == true &&
            candle3.GetComponent<CandleActivation>().isLit == true &&
            candle4.GetComponent<CandleActivation>().isLit == false &&
            candle5.GetComponent<CandleActivation>().isLit == true)
        {
            Debug.Log("Nice Job!");
        }
    }
}
