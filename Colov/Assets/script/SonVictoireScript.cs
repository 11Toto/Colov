using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SonVictoireScript : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource audioSource;

    void Start()
    {
        audioSource.PlayOneShot(clip);
    }

}
