using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScript : MonoBehaviour
{


    

    void OnTriggerEnter(Collider other)
    {
         



        if (SceneManager.GetActiveScene().name == "Game_Scene_LVL1")
        {
            if (other.transform.gameObject.tag == "Red")
            {
                SceneManager.LoadScene("Game_Scene_LVL2");
            }
            if (other.transform.gameObject.tag == "Blue")
            {
                SceneManager.LoadScene("Game_Scene_LVL2");

            }
            if (other.transform.gameObject.tag == "Green")
            {
                SceneManager.LoadScene("Game_Scene_LVL2");
            }
            if (other.transform.gameObject.tag == "Yellow")
            {
                SceneManager.LoadScene("Game_Scene_LVL2");
            }
            if (other.transform.gameObject.tag == "Purple")
            {
                SceneManager.LoadScene("Game_Scene_LVL2");
            }
        }

        if (SceneManager.GetActiveScene().name == "Game_Scene_LVL2")
        {
            if (other.transform.gameObject.tag == "Red")
            {
                SceneManager.LoadScene("Game_Scene_LVL3");
            }
            if (other.transform.gameObject.tag == "Blue")
            {
                SceneManager.LoadScene("Game_Scene_LVL3");
            }
            if (other.transform.gameObject.tag == "Green")
            {
                SceneManager.LoadScene("Game_Scene_LVL3");
            }
            if (other.transform.gameObject.tag == "Yellow")
            {
                SceneManager.LoadScene("Game_Scene_LVL3");
            }
            if (other.transform.gameObject.tag == "Purple")
            {
                SceneManager.LoadScene("Game_Scene_LVL3");
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
