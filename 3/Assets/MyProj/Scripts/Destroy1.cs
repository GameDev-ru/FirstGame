using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy1 : MonoBehaviour
{
    public GameObject target;



    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Player"))
        {
            if (!other.CompareTag("Player")) { Destroy(target); }

        }

    }
}
