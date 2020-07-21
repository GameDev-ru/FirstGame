using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP2 : MonoBehaviour
{

    public Teleportation1 target;
    public Rigidbody rb;
 
    void Start()
    {
        rb = rb.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Sphere"))
        {

            other.gameObject.transform.position = target.gameObject.transform.position;
            rb.isKinematic = true;
            rb.isKinematic = false;

        }
    }
}
