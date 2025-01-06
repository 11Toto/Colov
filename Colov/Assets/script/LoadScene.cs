using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{



    public void LoadGame()
    {
        SceneManager.LoadScene("Game_Scene_LVL1");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu_Scene_VF");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Au revoir");
    }

    
}
