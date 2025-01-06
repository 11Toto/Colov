using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.tag == "Red")
        {
            SceneManager.LoadScene("Victoire_Scene");
        }
        if (other.transform.gameObject.tag == "Blue")
        {
            SceneManager.LoadScene("Victoire_Scene");
        }
        if (other.transform.gameObject.tag == "Green")
        {
            SceneManager.LoadScene("Victoire_Scene");
        }
        if (other.transform.gameObject.tag == "Yellow")
        {
            SceneManager.LoadScene("Victoire_Scene");
        }
        if (other.transform.gameObject.tag == "Purple")
        {
            SceneManager.LoadScene("Victoire_Scene");
        }
        
    }
}
