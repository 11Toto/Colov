using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterSoundManager : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip[] clipIn;
    public AudioClip[] clipOut;
    public GameObject player;
    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == player.tag + "Obstacle")
        {
            
            AudioClip randomClip = clipIn[Random.Range(0, clipIn.Length)];

            audioSource.PlayOneShot(randomClip);
        }
        
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == player.tag + "Obstacle")
        {
            AudioClip randomClip = clipOut[Random.Range(0, clipOut.Length)];

            audioSource.PlayOneShot(randomClip);
        }
    }
}
