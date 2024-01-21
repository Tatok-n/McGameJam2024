using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBetweenRooms : MonoBehaviour
{
    public Transform respawnPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = respawnPoint.position;
            other.transform.rotation = respawnPoint.rotation;

            Destroy(this.gameObject);
        }
        else
        {
            return;
        }
    }
}
