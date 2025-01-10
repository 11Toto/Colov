using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScriptVA : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
         



        if (SceneManager.GetActiveScene().name == "Game_Scene_LVL1_VA")
        {
            if (other.transform.gameObject.tag == "Red")
            {
                SceneManager.LoadScene("Suivant_LVL1_2_Scene_VA");
            }
            if (other.transform.gameObject.tag == "Blue")
            {
                SceneManager.LoadScene("Suivant_LVL1_2_Scene_VA");

            }
            if (other.transform.gameObject.tag == "Green")
            {
                SceneManager.LoadScene("Suivant_LVL1_2_Scene_VA");
            }
            if (other.transform.gameObject.tag == "Yellow")
            {
                SceneManager.LoadScene("Suivant_LVL1_2_Scene_VA");
            }
            if (other.transform.gameObject.tag == "Purple")
            {
                SceneManager.LoadScene("Suivant_LVL1_2_Scene_VA");
            }
        }

        if (SceneManager.GetActiveScene().name == "Game_Scene_LVL2_VA")
        {
            if (other.transform.gameObject.tag == "Red")
            {
                SceneManager.LoadScene("Suivant_LVL2_3_Scene_VA");
            }
            if (other.transform.gameObject.tag == "Blue")
            {
                SceneManager.LoadScene("Suivant_LVL2_3_Scene_VA");
            }
            if (other.transform.gameObject.tag == "Green")
            {
                SceneManager.LoadScene("Suivant_LVL2_3_Scene_VA");
            }
            if (other.transform.gameObject.tag == "Yellow")
            {
                SceneManager.LoadScene("Suivant_LVL2_3_Scene_VA");
            }
            if (other.transform.gameObject.tag == "Purple")
            {
                SceneManager.LoadScene("Suivant_LVL2_3_Scene_VA");
            }
        }

         if (SceneManager.GetActiveScene().name == "Game_Scene_LVL3_VA")
        {
            if (other.transform.gameObject.tag == "Red")
            {
                SceneManager.LoadScene("Victory_Scene_VA");
                
            }
            if (other.transform.gameObject.tag == "Blue")
            {
                SceneManager.LoadScene("Victory_Scene_VA");
                
            }
            if (other.transform.gameObject.tag == "Green")
            {
                SceneManager.LoadScene("Victory_Scene_VA");
                
            }
            if (other.transform.gameObject.tag == "Yellow")
            {
                SceneManager.LoadScene("Victory_Scene_VA");
                
            }
            if (other.transform.gameObject.tag == "Purple")
            {
                SceneManager.LoadScene("Victory_Scene_VA");
                
            }
        }    
    }
}
