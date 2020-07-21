using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomObject : MonoBehaviour
{
    private Vector3 startPosition;

    
    public void Reset()
    {
        transform.position = startPosition;
        var rb = GetComponent<Rigidbody>();
        
        if (rb != null) rb.Sleep();

        gameObject.SetActive(true);
    }


    // Start is called before the first frame update
    void Awake()
    {
        startPosition = transform.position;
    }

    
}
