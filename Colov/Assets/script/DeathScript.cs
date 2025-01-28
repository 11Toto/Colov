using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour
{
    ChangeColor LevelDeathScript => GetComponent<ChangeColor>();
    bool dead = false;
    public int Levelcurrent = 0;


    void Awake()
    {
        switch(SceneManager.GetActiveScene().name)
        {
            case "Game_Scene_LVL1":Levelcurrent=1; break;
            case "Game_Scene_LVL2":Levelcurrent=2; break;
            case "Game_Scene_LVL3":Levelcurrent=3; break;
        }
    }

    public void Mort()
    {
        if (dead) return;
        dead = true;

        /*switch(LevelDeathScript.currentLevel)
        {
            case 1: SceneManager.LoadScene("Defaite_Scene_VF"); break;
            case 2: SceneManager.LoadScene("Defaite_Scene_2_VF"); break;
            case 3: SceneManager.LoadScene("Defaite_Scene_3_VF"); break;
        }*/

        if (Levelcurrent == 1)
        {
            SceneManager.LoadScene("Defaite_Scene_VF");
        }

        if (Levelcurrent == 2)
        {
            SceneManager.LoadScene("Defaite_Scene_2_VF");
        }

        if (Levelcurrent == 3)
        {
            SceneManager.LoadScene("Defaite_Scene_3_VF");
        }

        
    }

    
}
