using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoScript : MonoBehaviour
{
    public bool timestop;

    void Start ()
    {
        timestop = false;
    }

    void Update()
    {
        if (timestop == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                 Time.timeScale = 1f;
            } 
        }

    }
    public void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0.3f;
        timestop = true;
    }
}
