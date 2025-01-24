using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour
{
    ChangeColor LevelDeathScript => GetComponent<ChangeColor>();
    bool dead = false;

    public void Mort()
    {
        if (dead) return;
        dead = true;

        switch(LevelDeathScript.currentLevel)
        {
            case 1: SceneManager.LoadScene("Defaite_Scene_VF"); break;
            case 2: SceneManager.LoadScene("Defaite_Scene_2_VF"); break;
            case 3: SceneManager.LoadScene("Defaite_Scene_3_VF"); break;
        }
    }

    
}
