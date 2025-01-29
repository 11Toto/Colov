using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundRandomUI : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip[] clipUI;

    public void PlayRandomSound()
    {
        AudioClip randomClip = clipUI[Random.Range(0, clipUI.Length)];

        audioSource.PlayOneShot(randomClip);
    }
}
