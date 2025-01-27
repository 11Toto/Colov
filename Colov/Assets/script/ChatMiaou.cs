using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatMiaou : MonoBehaviour
{
    public List<AudioClip> audioClips;
    public AudioSource audioSource;

    
    public void AudioCat()
    {
    int r = Random.Range(0, audioClips.Count);
    AudioClip clip = audioClips[r];
    audioSource.clip = clip;
    audioSource.Play();
    }
}
