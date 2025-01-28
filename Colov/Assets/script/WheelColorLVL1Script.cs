using UnityEngine;
using DG.Tweening;

public class WheelColorLVL1Script : MonoBehaviour
{
    public GameObject Wheel;
    ChangeColor changeColorScript =>GetComponent<ChangeColor>();

    public bool SetActive { get; private set; }

    // transform.DORotate(new Vector3 (3.7f, -3.7f, -118f), 1f); == Couleur Rouge
    // transform.DORotate(new Vector3 (3.7f, -3.7f, 8.9f), 1f); == Couleur Bleu
    // transform.DORotate(new Vector3 (3.7f, -3.7f, 127f), 1f); == Couleur Vert

    float angle = 120f;

    void Start()
    {
        foreach (Transform child in Wheel.transform)
        {
            child.gameObject.SetActive(false);
        }

        switch (changeColorScript.currentLevel)
        {
            case 1: angle = 120f;break;
            case 2: angle = 90f; break;
            case 3: angle = 72f; break;
        }

        Wheel.transform.GetChild(changeColorScript.currentLevel-1).gameObject.SetActive(true);
    }


   public void Update()
   {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Wheel.transform.DOLocalRotate(-Vector3.forward*angle, 0.3f,RotateMode.LocalAxisAdd).SetEase(Ease.OutBack);
        }

    // if( color==0)
    // {
    //     if (Input.GetKeyDown(KeyCode.Space))
    //     {
    //         WheelLVL1.transform.DORotate(new Vector3 (3.7f, -3.7f, 8.9f), 1f);
    //         color = 1;
    //         return;
    //     }
    // }

    // if (color==1)
    // {
    //     if (Input.GetKeyDown(KeyCode.Space))
    //     {
    //         WheelLVL1.transform.DORotate(new Vector3 (3.7f, -3.7f, 127f), 1f);
    //         color = 2;
    //         return;
    //     }
    // }

    // if (color==2)
    // {
    //     if (Input.GetKeyDown(KeyCode.Space))
    //     {
    //         WheelLVL1.transform.DORotate(new Vector3 (3.7f, -3.7f, -118f), 1f);
    //         color = 0;
    //         return;
    //     }
    // }
   }

   void OnTriggerEnter(Collider other)
   {
     if(other.gameObject.transform.tag == "TriggerCamera")
     {
        Wheel.transform.parent = null;
        Destroy(Wheel.gameObject);
     }
   }
}
