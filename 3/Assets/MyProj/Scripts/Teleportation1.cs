using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation1 : MonoBehaviour
{

    public Teleportation1 target;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Cube") || other.CompareTag("Sphere"))
        {
            
            other.gameObject.transform.position = target.gameObject.transform.position;


        }
    }
}
