using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public GameObject player;
    private Vector3 lastPlayerPosition;


    void Start()
    {
        lastPlayerPosition = player.transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Checkpoint")
        {
            lastPlayerPosition = other.transform.position;
            Debug.Log("Checkpoint hit");
        }

        if (other.tag == "OutOfBounds")
        {
            Debug.Log("player went out of bounds");
            Debug.Log(lastPlayerPosition);
            // Reset player force and rotation
            var rb = player.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0, 0, 0);
            player.transform.position = lastPlayerPosition;
        }

    }
}
