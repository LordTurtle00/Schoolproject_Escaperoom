using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleActivation : MonoBehaviour
{
    public bool isLit = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wand" && isLit == false)
        {
            isLit = true;
        }
        if (collision.gameObject.tag == "wand" && isLit)
        {
            isLit = false;
        }
    }
}
