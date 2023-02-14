using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootWash : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        if (other.tag == "dirt")
        {
            other.gameObject.GetComponent<Rigidbody>().useGravity = true;
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
