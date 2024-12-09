using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Game_Scene");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu_Scene");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Au revoir");
    }

    
}
