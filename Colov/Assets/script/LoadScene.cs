using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public bool Anim = false;
    float timeAnim = 0.5f;
    float timeButton = 0.7f;


    IEnumerator TimerAnim()
    {
        yield return new WaitForSeconds(timeAnim);
        SceneManager.LoadScene("StoryBoard_Scene");
    }

    IEnumerator TimerButtonGameVF()
    {
        yield return new WaitForSeconds(timeButton);
        Anim = true;
        StartCoroutine(TimerAnim());
    }
    IEnumerator TimerButtonGameVFRestart()
    {
        yield return new WaitForSeconds(timeButton);
        SceneManager.LoadScene("Game_Scene_LVL1");
        
    }
    IEnumerator TimerButtonMenuVF()
    {
        yield return new WaitForSeconds(timeButton);
        SceneManager.LoadScene("Menu_Scene_VF");
        
    }
    IEnumerator TimerButtonOptionVF()
    {
        yield return new WaitForSeconds(timeButton);
        SceneManager.LoadScene("Option_Scene_VF");
        
    }
    IEnumerator TimerButtonGameLVL2()
    {
        yield return new WaitForSeconds(timeButton);
        SceneManager.LoadScene("Game_Scene_LVL2");
        
    }
    IEnumerator TimerButtonGameLVL3()
    {
        yield return new WaitForSeconds(timeButton);
        SceneManager.LoadScene("Game_Scene_LVL3");
        
    }
    IEnumerator TimerQuitGame()
    {
        yield return new WaitForSeconds(timeButton);
        Application.Quit();
        Debug.Log("Au revoir");
        Anim = true;
        
    }

    

    public void LoadGameVF()
    {
        StartCoroutine(TimerButtonGameVF());
    }

    public void LoadGameVFRestart()
    {
        StartCoroutine(TimerButtonGameVFRestart());
    }


    public void LoadMenuVF()
    {
        StartCoroutine(TimerButtonMenuVF());
    }


    public void LoadOptionVF()
    {
       StartCoroutine(TimerButtonOptionVF());
    }


    public void LoadGameLVL2()
    {
       StartCoroutine(TimerButtonGameLVL2());
    }

    public void LoadGameLVL3()
    {
       StartCoroutine(TimerButtonGameLVL3());
    }



    public void QuitGame()
    {
        StartCoroutine(TimerQuitGame());
    }
}
