using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleActivation : MonoBehaviour
{
    public bool isLit = false;
    //ParticleSystem particles = GetComponentInChildren<ParticleSystem>();

    private void Start()
    {
        //GameObject candleFire = GetComponentInChildren<BasicFire>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("wand found");
        if (collision.gameObject.tag == "wand" && isLit == false)
        {
            isLit = true;
            //ParticleSystem.enableEmission = true;
        }
        else
        {
            isLit = false;
        }
    }
}
