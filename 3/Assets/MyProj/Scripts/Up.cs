using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up : MonoBehaviour
{
    public GameObject destroy;
    public Vector3 startPosition;
    public Vector3 endPosition;
    public float step;
    private float progress;
    public bool inTrigger;
    private void Start()
    {
        inTrigger = false;
        transform.position = startPosition;
    }
    void FixedUpdate()
    {
        if (inTrigger == true)
        {
            transform.position = Vector3.Lerp(startPosition, endPosition, progress * Time.deltaTime);
            progress += step;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = true;
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            Destroy(destroy);
        }
    }
}