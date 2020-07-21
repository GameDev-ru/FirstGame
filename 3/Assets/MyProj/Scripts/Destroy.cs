using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject target;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sphere"))
        {
            Destroy(target);
        }
        if (other.CompareTag("Player"))
        {
            Destroy(target,4);
        }

    }

}
