using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBall : MonoBehaviour
{
    
    public GameObject Ball;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Ball")) Instantiate(Ball, new Vector3(0, 16, 25), Quaternion.identity);
    }


}
