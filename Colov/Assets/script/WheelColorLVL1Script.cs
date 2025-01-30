using UnityEngine;
using DG.Tweening;

public class WheelColorLVL1Script : MonoBehaviour
{
    public GameObject Wheel;
    ChangeColor changeColorScript =>GetComponent<ChangeColor>();

    public bool SetActive { get; private set; }


    float angle = 120f;
    public float Lvl;

    void Start()
    {
        foreach (Transform child in Wheel.transform)
        {
            child.gameObject.SetActive(false);
        }

        switch (changeColorScript.currentLevel)
        {
            case 1: angle = 120f;Lvl =1;break;
            case 2: angle = 90f;Lvl =2; break;
            case 3: angle = 72f;Lvl =3; break;
        }

        Wheel.transform.GetChild(changeColorScript.currentLevel-1).gameObject.SetActive(true);
    }


   public void Update()
   {
        if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Wheel.transform.DOLocalRotate(-Vector3.forward*angle, 0.3f,RotateMode.LocalAxisAdd).SetEase(Ease.OutBack);


            if (Lvl == 1)
        {
            if (transform.tag == "Red")
            {
                Wheel.transform.localEulerAngles = new Vector3 (0, 0, 0);
            }
            if (transform.tag == "Blue")
            {
                Wheel.transform.localEulerAngles = new Vector3 (0, 0, -120);
            }
            if (transform.tag == "Green")
            {
                Wheel.transform.localEulerAngles = new Vector3 (0, 0, 120);
            }
        }

        if (Lvl == 2)
        {
            {

            }
            if (transform.tag == "Red")
            {
                Wheel.transform.localEulerAngles = new Vector3 (0, 0, 0);
            }
            if (transform.tag == "Blue")
            {
                Wheel.transform.localEulerAngles = new Vector3 (0, 0, -90);
            }
            if (transform.tag == "Green")
            {
                Wheel.transform.localEulerAngles = new Vector3 (0, 0, 180);
            }
            if (transform.tag == "Yellow")
            {
                Wheel.transform.localEulerAngles = new Vector3 (0, 0, 90);
            }
        }
            if (Lvl == 3)
        {
            if (transform.tag == "Red")
            {
                Wheel.transform.localEulerAngles = new Vector3 (0, 0, 0);
            }
            if (transform.tag == "Blue")
            {
                Wheel.transform.localEulerAngles = new Vector3 (0, 0, -72);
            }
            if (transform.tag == "Green")
            {
                Wheel.transform.localEulerAngles = new Vector3 (0, 0, -144);
            }
            if (transform.tag == "Yellow")
            {
                Wheel.transform.localEulerAngles = new Vector3 (0, 0, 144);
            }
            if (transform.tag == "Purple")
            {
                Wheel.transform.localEulerAngles = new Vector3 (0, 0, 72);
            }
        }
        }

        
   }

   void OnTriggerEnter(Collider other)
   {
     if(other.gameObject.transform.tag == "TriggerCamera")
     {
        Wheel.transform.parent = null;
        Wheel.gameObject.SetActive(false);
        Wheel = null;
        
     }
   }
}
