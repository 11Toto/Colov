using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public CharacterMovement player;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "skibidi")
        {
            Debug.Log("wow");
            player.speed = 0; 
        }
    }
}
