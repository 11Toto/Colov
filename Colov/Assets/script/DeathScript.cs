using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour
{
    bool dead = false;

    public void Mort()
    {
        if (dead) return;
        dead = true;
        SceneManager.LoadScene("Defaite_Scene_VF");
    }

    
}
