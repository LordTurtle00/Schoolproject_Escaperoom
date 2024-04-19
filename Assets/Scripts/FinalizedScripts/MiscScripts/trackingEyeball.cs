using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackingEyeball : MonoBehaviour
{
    public GameObject target;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        gameObject.transform.LookAt(target.transform.position);
    }
}
