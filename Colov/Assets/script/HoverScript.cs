using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HoverScript : MonoBehaviour
{
    public Vector2 movement = Vector2.zero;
    public float duration = 1f;
    public Ease easing = Ease.InOutCubic;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(-new Vector3(movement.x,movement.y,0)*0.5f);
        transform.DOMove(transform.position +new Vector3(movement.x,movement.y,0),duration).SetLoops(-1,LoopType.Yoyo).SetEase(easing).SetUpdate(true);
    }

}
