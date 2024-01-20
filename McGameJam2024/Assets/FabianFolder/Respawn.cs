using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform respawnPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = respawnPoint.position;
            other.transform.rotation = respawnPoint.rotation;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
