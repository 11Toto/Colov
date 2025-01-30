using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleParticles : MonoBehaviour
{
    public ParticleSystem particleSystemObstacle;

    void OnTriggerEnter(Collider other)
    {
        particleSystemObstacle.Play();
    }
}
