using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public int speed = 3;
    public string GoodColor;

    private void Start()
    {
        GoodColor = gameObject.tag;
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
        Debug.Log("touch");
        if (other.tag == GoodColor)
        {
            Debug.Log("pass");
        }
        else
        {
            Debug.Log("stop");
            speed = 0;
        }
    }

}
