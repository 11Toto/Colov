using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AnimFondNoir : MonoBehaviour
{
    void Awake()
    {
        transform.DOScaleX (0f, 2f);
        transform.DOScaleY (0f, 2f);
        transform.DOScaleZ (0f, 2f);
    }
}
