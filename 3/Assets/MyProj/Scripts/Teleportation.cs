using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    
    public Teleportation target;

   
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

           
            other.gameObject.transform.position = target.gameObject.transform.position;

        }
    }
}
