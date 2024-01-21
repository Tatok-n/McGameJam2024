using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundAtLocation : MonoBehaviour
{
    public AudioSource source;
    public bool hasPlayed = false;

    private void Start()
    {
        AudioSource source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !hasPlayed)
        {
            source.Play();
            hasPlayed = true;
            //Destroy(this.gameObject);
        }
        else
        {
            return;
        }
    }
}
