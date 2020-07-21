using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public GameObject target;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sphere"))
        {
            target.SetActive(false);
        }
    }
}
