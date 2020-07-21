using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    private AudioSource sound;

    public bool isGround;
    public AudioClip jump;
    public AudioClip col;

    void Awake()
    {
        sound = GetComponent<AudioSource>();
        isGround = GetComponent<Controller>().isGround;

    }

    private void Update()
    {
        Jump();
    }

    public void Jump()
    {
        if (Input.GetKey(KeyCode.Space) && isGround)
        {
            sound.clip = jump;
            sound.Play();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        sound.clip = col;
        sound.Play();
        isGround = true;

    }
    private void OnCollisionExit(Collision collision)
    {
        isGround = false;

    }

}
