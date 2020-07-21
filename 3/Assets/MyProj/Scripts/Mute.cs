using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{
    private AudioSource mute;



    private void Awake()
    {
       
        mute = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
           
            mute.mute = true;
        }
    }
}
