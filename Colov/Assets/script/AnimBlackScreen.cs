using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Animations;

public class AnimBlackScreen : MonoBehaviour
{
    


    void Update()
    {

        if (GameObject.Find("Script - LoadScene").GetComponent<LoadScene>().Anim) 
    {			
        transform.DOScaleX (60f, 1f);
        transform.DOScaleZ (45f, 1f);  
	}
        /*transform.DOScaleX (0f, 3f);
        transform.DOScaleY (0f, 3f);
        transform.DOScaleZ (0f, 3f);*/
        /*if( = true)
        {
            transform.DOScaleX (39f, 1f);
            transform.DOScaleZ (25f, 1f);
        }*/

    }

}
