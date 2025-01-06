using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMovement : MonoBehaviour
{
    public int speed = 3;
    ChangeColor colorScript => GetComponent<ChangeColor>();
    public DeathScript deathScript;

    void Start()
    {

    }
    void Update()
    {
        Vector3 scrolling = Vector3.zero;
        scrolling.x = speed;

        Vector3 movement = scrolling * Time.deltaTime;
        transform.Translate(movement);
    }

    void OnTriggerEnter(Collider other)
    {
     Debug.Log(other.name);
          switch(other.tag)
          {
               default: break;
               case "RedObstacle": if (colorScript.currentColor!=ChangeColor.CharacterColor.Red) {Debug.Log("Tu es Mort par Red"); Mort();} break;
               case "BlueObstacle": if (colorScript.currentColor!=ChangeColor.CharacterColor.Blue) {Debug.Log("Tu es Mort par Blue"); Mort();} break;
               case "GreenObstacle": if (colorScript.currentColor!=ChangeColor.CharacterColor.Green) {Debug.Log("Tu es Mort par Green"); Mort();} break;
               case "YellowObstacle": if (colorScript.currentColor!=ChangeColor.CharacterColor.Yellow) {Debug.Log("Tu es Mort par Yellow"); Mort();} break;
               case "PurpleObstacle": if (colorScript.currentColor!=ChangeColor.CharacterColor.Purple) {Debug.Log("Tu es Mort par Purple"); Mort();} break;
          }
    }


    void Mort()
    {
          speed = 0;
          deathScript.Mort();
    }

}