using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{



    public void LoadGameVF()
    {
        SceneManager.LoadScene("Game_Scene_LVL1");
    }

    public void LoadGameVA()
    {
        SceneManager.LoadScene("Game_Scene_LVL1_VA");
    }

    public void LoadMenuVF()
    {
        SceneManager.LoadScene("Menu_Scene_VF");
    }

    public void LoadMenuVA()
    {
        SceneManager.LoadScene("Menu_Scene_VA");
    }

    public void LoadOptionVF()
    {
        SceneManager.LoadScene("Option_Scene_VF");
    }

    public void LoadOptionVA()
    {
        SceneManager.LoadScene("Option_Scene_VA");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Au revoir");
    }

    
}
