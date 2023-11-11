using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidbodySleep : MonoBehaviour
{
    private int sleepcountdown = 4;

    private Rigidbody rigid;

    void Awake()
    {
       rigid = GetComponent<Rigidbody>();   
    }
   
    // Update is called once per frame
    void FixedUpdate()
    {
        if (sleepcountdown > 0)
        {
            rigid.Sleep(); 
            sleepcountdown--;
        }
    }
}
