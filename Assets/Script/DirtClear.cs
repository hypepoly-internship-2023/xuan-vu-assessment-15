using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtClear : MonoBehaviour
{
    [SerializeField] protected Rigidbody rb;

    public void falldown()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.isKinematic = false;
    }    
}
