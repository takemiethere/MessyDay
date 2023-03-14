using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioClip audioClip;
    private AudioSource audioSource;
    private bool hasPlayed;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        hasPlayed = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !hasPlayed)
        {
            audioSource.PlayOneShot(audioClip);
            hasPlayed = true;
        }
    }
}

