using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChangeColorAnim : MonoBehaviour
{
   public GameObject Perso;
    float tourne = 360f;
    

    void Update()
    {
        if (Perso.transform.gameObject.tag == "Red" && Input.GetKeyDown(KeyCode.Space))
        {
            transform.DOLocalRotate(-Vector3.forward*tourne, 0.3f,RotateMode.LocalAxisAdd).SetEase(Ease.OutBack).OnComplete(() => {transform.eulerAngles = new Vector3(0, 0, 0);});
        }

        if (Perso.transform.gameObject.tag == "Blue" && Input.GetKeyDown(KeyCode.Space))
        {
            transform.DOLocalRotate(-Vector3.forward*tourne, 0.3f,RotateMode.LocalAxisAdd).SetEase(Ease.OutBack).OnComplete(() => {transform.eulerAngles = new Vector3(0, 0, 0);});
        }

        if (Perso.transform.gameObject.tag == "Green" && Input.GetKeyDown(KeyCode.Space))
        {
            transform.DOLocalRotate(-Vector3.forward*tourne, 0.3f,RotateMode.LocalAxisAdd).SetEase(Ease.OutBack).OnComplete(() => {transform.eulerAngles = new Vector3(0, 0, 0);});
        }

        if (Perso.transform.gameObject.tag == "Yellow" && Input.GetKeyDown(KeyCode.Space))
        {
            transform.DOLocalRotate(-Vector3.forward*tourne, 0.3f,RotateMode.LocalAxisAdd).SetEase(Ease.OutBack).OnComplete(() => {transform.eulerAngles = new Vector3(0, 0, 0);});
        }

        if (Perso.transform.gameObject.tag == "Purple" && Input.GetKeyDown(KeyCode.Space))
        {
            transform.DOLocalRotate(Vector3.forward*tourne, 0.3f,RotateMode.LocalAxisAdd).SetEase(Ease.OutBack).OnComplete(() => {transform.eulerAngles = new Vector3(0, 0, 0);});
        }
    }
}
