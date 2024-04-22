using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CobinationLock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void LockRotate(float dirc)
    {
        transform.Rotate(new Vector3(0, dirc, 0));
    }
   
    void Update()
    {
        
    }
}
