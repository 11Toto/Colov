using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public float timeBetweenChange = 0.3f;
    private float timestamp; 
    public Material[] materials;
    public MeshRenderer meshRenderer;

    void Start()
    {
    
        transform.gameObject.tag = "Red";
    }

    
    void Update()
    {
       
       ChangeSpriteColor();
    }

    void ChangeTagColor()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Niveau1")
        {
            Debug.Log("Niveau1");
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
                        transform.gameObject.tag = "Red";
                        timestamp = Time.time + timeBetweenChange;
                    }

        }

        else if (other.gameObject.tag == "Niveau2")
        {
            Debug.Log("Niveau2");
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
                        transform.gameObject.tag = "Red";
                        timestamp = Time.time + timeBetweenChange;
                    }
        }

        else if (other.gameObject.tag == "Niveau3")
        {
            Debug.Log("Niveau3");
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

    void ChangeSpriteColor()
    {
            if (transform.gameObject.tag == "Red")
            {
                meshRenderer.material = materials[0];
            }
            if (transform.gameObject.tag == "Blue")
            {
                meshRenderer.material = materials[1];
            }
            if (transform.gameObject.tag == "Green")
            {
                meshRenderer.material = materials[2];
            }
            if (transform.gameObject.tag == "Yellow")
            {
                meshRenderer.material = materials[3];
            }
            if (transform.gameObject.tag == "Purple")
            {
                meshRenderer.material = materials[4];
            }
    }

    
}
    