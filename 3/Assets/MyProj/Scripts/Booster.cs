using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    public float force;
    public float jumpForce;
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody sphereRb;
        if (other.CompareTag("Sphere"))
        {
            sphereRb = other.GetComponent<Rigidbody>();
            sphereRb.AddForce(transform.up * jumpForce);
            sphereRb.AddForce(Vector3.left * force);
        }
    }


}
