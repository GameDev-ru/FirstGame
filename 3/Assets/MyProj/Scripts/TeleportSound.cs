using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportSound : MonoBehaviour
{
    private AudioSource teleport;
    public AudioClip teleportPlayer;
    public AudioClip teleportCube;
    public AudioClip target;


    private void Awake()
    {

        teleport = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            teleport.volume = 1;
            teleport.clip = teleportPlayer;
            teleport.Play();
        }
        if (other.CompareTag("Cube"))
        {
            teleport.volume = 0.45f;
            teleport.clip = teleportCube;
            teleport.Play();
        }
        if (other.CompareTag("Sphere"))
        {
            teleport.clip = target;
            teleport.Play();
        }
    }
}
