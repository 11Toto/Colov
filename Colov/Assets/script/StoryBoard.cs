using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using Unity.VisualScripting;

public class StoryBoard : MonoBehaviour
{
    public GameObject[] storyboard;
    public int board = 0;

    float timeBoard1 = 4.1f;
    float timeBoard2 = 4.1f;
    float timeBoard3 = 4.1f;
    float timeBoard4 = 4.1f;
    float timeBoard5 = 3.5f;
    float timeBoard6 = 4.1f;
    float timeBoard7 = 6.1f;
    float timeBoard8 = 3.4f;


    IEnumerator TimerBoard1()
    {
        yield return new WaitForSeconds(timeBoard1);
        StartCoroutine(TimerBoard2());
    }
     IEnumerator TimerBoard2()
    {
        storyboard[2].transform.DOScale(1f, 3f);
        yield return new WaitForSeconds(timeBoard2);
        StartCoroutine(TimerBoard3());
    }
     IEnumerator TimerBoard3()
    {
        storyboard[3].transform.DOScale(1f, 3f);
        yield return new WaitForSeconds(timeBoard3);
        StartCoroutine(TimerBoard4());
    }
     IEnumerator TimerBoard4()
    {
        storyboard[4].transform.DOScale(1f, 3f);
        yield return new WaitForSeconds(timeBoard4);
        StartCoroutine(TimerBoard5());
    }
     IEnumerator TimerBoard5()
    {
        storyboard[5].transform.DOScale(1f, 3f);
        yield return new WaitForSeconds(timeBoard5);
        StartCoroutine(TimerBoard6());
    }
     IEnumerator TimerBoard6()
    {
        storyboard[6].transform.DOScale(1f, 3f);
        yield return new WaitForSeconds(timeBoard6);
        StartCoroutine(TimerBoard7());
    }
     IEnumerator TimerBoard7()
    {
        storyboard[7].transform.DOScale(1f, 3f);
        yield return new WaitForSeconds(timeBoard7);
        StartCoroutine(TimerBoard8());
    }
     IEnumerator TimerBoard8()
    {
        storyboard[8].transform.DOScale(2f, 3f);
        yield return new WaitForSeconds(timeBoard8);
        SceneManager.LoadScene("Game_Scene_LVL1");
    }
    public void Awake()
    {
        storyboard[1].transform.DOScale(1f, 3f);
        StartCoroutine(TimerBoard1());
    }


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            SceneManager.LoadScene("Game_Scene_LVL1");
        }
    }
}
