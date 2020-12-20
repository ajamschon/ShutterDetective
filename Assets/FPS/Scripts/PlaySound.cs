using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {

    public AudioSource playSound;
    public bool alreadyPlayed = false;
    
    void OnTriggerEnter(Collider other)
    {
        if (!alreadyPlayed) {
            playSound.Play();
            alreadyPlayed = true;
        }
    }
}