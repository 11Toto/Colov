using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class AnimChatMenu : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.DOScaleX (1.3f, 0.3f);
        transform.DOScaleY (1.3f, 0.3f); 
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.DOScaleX (1f, 0.3f);
        transform.DOScaleY (1f, 0.3f); 
    }
}
