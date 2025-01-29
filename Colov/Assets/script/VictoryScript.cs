using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScript : MonoBehaviour
{

    public AudioSource audioSource;

    public AudioClip clip;


    void OnTriggerEnter(Collider other)
    {

        
        if (SceneManager.GetActiveScene().name == "Game_Scene_LVL1")
        {
            if (other.transform.gameObject.tag == "Red")
            {
                SceneManager.LoadScene("Suivant_LVL1_2_Scene_VF");
            }
            if (other.transform.gameObject.tag == "Blue")
            {
                SceneManager.LoadScene("Suivant_LVL1_2_Scene_VF");

            }
            if (other.transform.gameObject.tag == "Green")
            {
                SceneManager.LoadScene("Suivant_LVL1_2_Scene_VF");
            }
            if (other.transform.gameObject.tag == "Yellow")
            {
                SceneManager.LoadScene("Suivant_LVL1_2_Scene_VF");
            }
            if (other.transform.gameObject.tag == "Purple")
            {
                SceneManager.LoadScene("Suivant_LVL1_2_Scene_VF");
            }
        }

        if (SceneManager.GetActiveScene().name == "Game_Scene_LVL2")
        {
            if (other.transform.gameObject.tag == "Red")
            {
                SceneManager.LoadScene("Suivant_LVL2_3_Scene_VF");
            }
            if (other.transform.gameObject.tag == "Blue")
            {
                SceneManager.LoadScene("Suivant_LVL2_3_Scene_VF");
            }
            if (other.transform.gameObject.tag == "Green")
            {
                SceneManager.LoadScene("Suivant_LVL2_3_Scene_VF");
            }
            if (other.transform.gameObject.tag == "Yellow")
            {
                SceneManager.LoadScene("Suivant_LVL2_3_Scene_VF");
            }
            if (other.transform.gameObject.tag == "Purple")
            {
                SceneManager.LoadScene("Suivant_LVL2_3_Scene_VF");
            }
        }

         if (SceneManager.GetActiveScene().name == "Game_Scene_LVL3")
        {
            if (other.transform.gameObject.tag == "Red")
            {
                SceneManager.LoadScene("Victoire_Scene_VF");
                
            }
            if (other.transform.gameObject.tag == "Blue")
            {
                SceneManager.LoadScene("Victoire_Scene_VF");
                
            }
            if (other.transform.gameObject.tag == "Green")
            {
                SceneManager.LoadScene("Victoire_Scene_VF");
                
            }
            if (other.transform.gameObject.tag == "Yellow")
            {
                SceneManager.LoadScene("Victoire_Scene_VF");
                
            }
            if (other.transform.gameObject.tag == "Purple")
            {
                SceneManager.LoadScene("Victoire_Scene_VF");
                
            }
        }    
    }
}
