using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpSound : MonoBehaviour
{
    private AudioSource up;

    private void Awake()
    {

        up = GetComponent<AudioSource>();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            up.Play();
            up.loop = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            up.loop = false;
        }
    }
}
