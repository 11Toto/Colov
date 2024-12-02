using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public float timeBetweenChange = 0.01f;
    private float timestamp; 

    void Start()
    {
    
        transform.gameObject.tag = "Red";
    }

    
    void Update()
    {
        if (transform.gameObject.tag == "Red")
            if (Time.time >= timestamp && Input.GetKey(KeyCode.Space)) 
            {
                transform.gameObject.tag = "Blue";
                timestamp = Time.time + timeBetweenChange;
            }

        if (transform.gameObject.tag == "Blue")
            if (Time.time >= timestamp && Input.GetKey(KeyCode.Space))
            {
                transform.gameObject.tag = "Green";
                timestamp = Time.time + timeBetweenChange;
            }
        if (transform.gameObject.tag == "Green")
            if (Time.time >= timestamp && Input.GetKey(KeyCode.Space))
            {
                transform.gameObject.tag = "Yellow";
                timestamp = Time.time + timeBetweenChange;
            }
        if (transform.gameObject.tag == "Yellow")
            if (Time.time >= timestamp && Input.GetKey(KeyCode.Space))
            {
                transform.gameObject.tag = "Purple";
                timestamp = Time.time + timeBetweenChange;
            }
        if (transform.gameObject.tag == "Purple")
            if (Time.time >= timestamp && Input.GetKey(KeyCode.Space))
            {
                transform.gameObject.tag = "Red";
                timestamp = Time.time + timeBetweenChange;
            }    

    }

    
}
    