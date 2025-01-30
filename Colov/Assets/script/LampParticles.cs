using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampParticles : MonoBehaviour
{
    public ParticleSystem particleSystemLamp;

    void OnTriggerEnter(Collider other)
    {
        particleSystemLamp.Play();
    }
}
