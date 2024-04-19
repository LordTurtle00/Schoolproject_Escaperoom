using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleActivation : MonoBehaviour
{
    public bool isLit = false;
    public ParticleSystem Cfire;
    public Light Clight;

    private void Start()
    {
        Cfire = GetComponentInChildren<ParticleSystem>();
        Clight = GetComponentInChildren<Light>();
        Clight.enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("wand found");
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
