using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomControler : MonoBehaviour
{
    private Controller player;
    public Transform startPosition;
    public List<RoomObject> resetObjects;

    private void HandlePlayerOnDie()
    {
        var rb = GetComponent<Rigidbody>();
        
        player.rb.Sleep();

        player.transform.position = startPosition.position;
        foreach (var item in resetObjects)
        {
            item.Reset();
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") == false) return;

        player = other.gameObject.GetComponent<Controller>();
        if (player != null)
        {
            player.onDie += HandlePlayerOnDie;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") == false) return;
        player.onDie -= HandlePlayerOnDie;
        player = null;
    }
}
