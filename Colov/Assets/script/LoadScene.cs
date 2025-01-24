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


    public void LoadMenuVF()
    {
        SceneManager.LoadScene("Menu_Scene_VF");
    }


    public void LoadOptionVF()
    {
        SceneManager.LoadScene("Option_Scene_VF");
    }


    public void LoadGameLVL1()
    {
        SceneManager.LoadScene("Game_Scene_LVL1");
    }

    public void LoadGameLVL2()
    {
        SceneManager.LoadScene("Game_Scene_LVL2");
    }

    public void LoadGameLVL3()
    {
        SceneManager.LoadScene("Game_Scene_LVL3");
    }



    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Au revoir");
    }

    
}
