using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Finish : MonoBehaviour
{
 
    public GameObject image;
    private AudioSource finish;



    private void Awake()
    {
        finish = GetComponent<AudioSource>();
    }

    void Start()
    {
        image.SetActive(false);
    }


    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            image.SetActive(true);
            finish.Play();
        }
    }

}
