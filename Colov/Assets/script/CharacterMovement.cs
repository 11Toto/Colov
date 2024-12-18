using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMovement : MonoBehaviour
{
    public bool Death;
    public int speed = 3;

    void Start()
    {
        Death = false;
    }
    void Update()
    {
        Vector3 scrolling = Vector3.zero;
        scrolling.x = speed;

        Vector3 movement = scrolling * Time.deltaTime;
        transform.Translate(movement);
    }

    void OnTriggerEnter(Collider other)
    {
        if (transform.gameObject.tag != "Red" && other.CompareTag("RedObstacle"))
        {
             Debug.Log("Tu es Mort par Red");
             speed = 0;
             Death = true;
        }
        if (transform.gameObject.tag != "Blue" && other.CompareTag("BlueObstacle"))
        {
             Debug.Log("Tu es Mort par Blue");
             speed = 0;
             Death = true;
        }
        if (transform.gameObject.tag != "Green" && other.CompareTag("GreenObstacle"))
        {
             Debug.Log("Tu es Mort par Green");
             speed = 0;
             Death = true;
        }
        if (transform.gameObject.tag != "Yellow" && other.CompareTag("YellowObstacle"))
        {
             Debug.Log("Tu es Mort par Yellow");
             speed = 0;
             Death = true;
        }
        if (transform.gameObject.tag != "Purple" && other.CompareTag("PurpleObstacle"))
        {
             Debug.Log("Tu es Mort par Purple");
             speed = 0;
             Death = true;
        }

       
    }

}