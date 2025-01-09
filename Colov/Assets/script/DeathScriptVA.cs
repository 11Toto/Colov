using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScriptVA : MonoBehaviour
{
    bool deadVA = false;

    public void MortVA()
    {
        if (deadVA) return;
        deadVA = true;
        SceneManager.LoadScene("Defeat_Scene_VA");
    }
}
