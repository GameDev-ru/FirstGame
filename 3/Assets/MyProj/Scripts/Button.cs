using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    private AudioSource button;
    
    public GameObject uiTXT;
    public GameObject race;

    void Awake()
    {
        button = GetComponent<AudioSource>();

    }

    void Start()
    {
        uiTXT.SetActive(false);
        race.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.E)) On();


    }

    public void On()
    {
        race.SetActive(true);
        button.Play();
    }
  
    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiTXT.SetActive(true);
        }
    }
    void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiTXT.SetActive(false);
        }
    }

}
