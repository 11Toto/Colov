using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class AnimButtonLang : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.DOScaleX (1.9f, 0.3f);
        transform.DOScaleY (1.4f, 0.3f); 
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.DOScaleX (1.5f, 0.3f);
        transform.DOScaleY (1f, 0.3f); 
    }
}
