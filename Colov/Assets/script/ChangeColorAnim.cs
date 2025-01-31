using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChangeColorAnim : MonoBehaviour
{
   public GameObject Perso;
   public GameObject[] fx;
    float turn = 360f;
    public float animDuration = 0.3f;

    ChangeColor.CharacterColor currentColor;


    public void SelectNewColor(ChangeColor.CharacterColor oldColor, ChangeColor.CharacterColor newColor)
    {
        currentColor = newColor;
        //transform.DOLocalRotate(-Vector3.forward*turn, animDuration,RotateMode.LocalAxisAdd).SetEase(Ease.OutBack).OnComplete(StopAnim);
        StartCoroutine(Animation());
    }


    IEnumerator Animation()
    {
        transform.DOScaleX(-4, animDuration / 2).SetEase(Ease.InCubic);
        transform.DOScaleY(-2, animDuration / 2).SetEase(Ease.InCubic);
        transform.DOLocalMoveY(0.5f, animDuration / 2).SetEase(Ease.InCubic);
        yield return new WaitForSeconds(animDuration / 2);
        transform.DOScaleX(-3.02f, animDuration / 2).SetEase(Ease.InCubic);
        transform.DOScaleY(-3.02f, animDuration / 2).SetEase(Ease.InCubic);
        transform.DOLocalMoveY(1.264f, animDuration / 2).SetEase(Ease.InCubic);
        StopAnim();
    }

    void StopAnim()
    {
        switch (currentColor)
        {
            case ChangeColor.CharacterColor.Red: Instantiate(fx[0], transform); break;
            case ChangeColor.CharacterColor.Blue: Instantiate(fx[1], transform); break;
            case ChangeColor.CharacterColor.Green: Instantiate(fx[2], transform); break;
            case ChangeColor.CharacterColor.Yellow: Instantiate(fx[3], transform); break;
            case ChangeColor.CharacterColor.Purple: Instantiate(fx[4], transform); break;
        }
        transform.localEulerAngles = Vector3.zero;
    }

}
