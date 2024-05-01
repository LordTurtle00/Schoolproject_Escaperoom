using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleActivation : MonoBehaviour
{
    //Defining variables that allow candles to have a "lit" state be on or off.
    public bool isLit = false;
    public ParticleSystem Cfire;
    public Light Clight;
    private void Start()
    {
        //Gets the light component as well as the fire particle present in the candle
        Cfire = GetComponentInChildren<ParticleSystem>();
        Clight = GetComponentInChildren<Light>();
        Clight.enabled = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Checks if the fire wand enters the collision box of the candle. If the candle is lit (isLit = true)
        //then the candle will "shut off", and vice versa. The isLit variable is checked later in candleController
        if (collision.gameObject.tag == "wand" && isLit == false)
        {
            isLit = true;
            Cfire.Play();
            Clight.enabled = true;
        }
        else
        {
            isLit = false;
            Cfire.Stop();
            Clight.enabled = false;
        }
    }
}
