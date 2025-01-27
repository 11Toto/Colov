using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoScript : MonoBehaviour
{
    public bool timestop;
    public GameObject doigt;

    void Start ()
    {
        timestop = false;
    }

    void Update()
    {
        if (timestop == true)
        {
            if (Input.GetKeyDown(KeyCode.Space)|| (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
            {
                TutoFinish();
            } 
        }

    }
    public void OnTriggerEnter(Collider other)
    {
        ActivateTuto();
    }


    void ActivateTuto()
    {
        doigt.SetActive(true);
        Time.timeScale = 0.3f;
        timestop = true;
    }

    void TutoFinish()
    {
        doigt.SetActive(false);
        Time.timeScale = 1f;
    }
}
