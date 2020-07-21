using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up2 : MonoBehaviour
{
    public float force;
    Rigidbody playerRb;
    public bool isTrigger;
    private void Start()
    {
        isTrigger = false;
    }
    private void FixedUpdate()
    {
        if(isTrigger == true)
        playerRb.AddForce(Vector3.up * force);
    }
    private void OnTriggerStay(Collider other)
    {
        
        
        if (other.CompareTag("Player"))
        {
            playerRb = other.GetComponent<Rigidbody>();
            isTrigger = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        isTrigger = false;
    }
}
