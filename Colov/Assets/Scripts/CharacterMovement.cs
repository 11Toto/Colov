using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public int speed = 3;
    public string badcolor = "Vert";
    void Update()
    {
        Vector3 scrolling = Vector3.zero;
        scrolling.x = speed;

        Vector3 movement = scrolling * Time.deltaTime;
        transform.Translate(movement);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("touché");
        if (other.tag == badcolor)
        {
            Debug.Log("stop");
            speed = 0;
        }
    }

}
