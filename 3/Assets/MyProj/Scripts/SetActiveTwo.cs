using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveTwo : MonoBehaviour
{
    public GameObject target;



    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            target.SetActive(false);
        }
    }
}
