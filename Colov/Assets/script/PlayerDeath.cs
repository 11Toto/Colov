using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (transform.gameObject.tag != "Red" && other.CompareTag("RedObstacle"))
        {
             Debug.Log("Tu es Mort par Red");
        }
        if (transform.gameObject.tag != "Blue" && other.CompareTag("BlueObstacle"))
        {
             Debug.Log("Tu es Mort par Blue");
        }
        if (transform.gameObject.tag != "Green" && other.CompareTag("GreenObstacle"))
        {
             Debug.Log("Tu es Mort par Green");
        }
        if (transform.gameObject.tag != "Yellow" && other.CompareTag("YellowObstacle"))
        {
             Debug.Log("Tu es Mort par Yellow");
        }
        if (transform.gameObject.tag != "Purple" && other.CompareTag("PurpleObstacle"))
        {
             Debug.Log("Tu es Mort par Purple");
        }
    }
}
