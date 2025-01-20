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

    bool isTweening = false;
    ChangeColor.CharacterColor currentColor;


    public void SelectNewColor(ChangeColor.CharacterColor oldColor, ChangeColor.CharacterColor newColor)
    {
        currentColor = newColor;
        //if (isTweening) return;
        isTweening = true;
        transform.DOLocalRotate(-Vector3.forward*turn, animDuration,RotateMode.LocalAxisAdd).SetEase(Ease.OutBack).OnComplete(StopAnim);
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
       // transform.DOKill();
        isTweening = false;
    }

}
