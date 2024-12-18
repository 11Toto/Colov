using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour
{
    public bool DeathScene = false;
    public GameObject Player;

    public void Update()
    {
        DeathScene = Player.GetComponent<CharacterMovement>().Death;
        if (DeathScene == true)
        {
            LoadDeath();
        }

    }

    public void LoadDeath()
    {
        if (DeathScene == true)
        {
            SceneManager.LoadScene("Defaite_Scene");
        }
    }
}
