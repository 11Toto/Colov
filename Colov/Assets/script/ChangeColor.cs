using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ChangeColor : MonoBehaviour
{
    //public Material[] materials;
    public GameObject[] spritesperso;

    //public MeshRenderer meshRenderer;
    ChangeColorAnim colorAnimScript =>GetComponentInChildren<ChangeColorAnim>();
   

    public int currentLevel = 0;

    public enum CharacterColor{Red, Blue,Green,Yellow,Purple}
    public CharacterColor currentColor = CharacterColor.Red;


    void Awake()
    {
        switch(SceneManager.GetActiveScene().name)
        {
            case "Game_Scene_LVL1":currentLevel=1; break;
            case "Game_Scene_LVL2":currentLevel=2; break;
            case "Game_Scene_LVL3":currentLevel=3; break;
        }


        SwitchColor(CharacterColor.Red);
    }


    
    void ChangeTagColor()
    {
        
    }

    public void SwitchColor(CharacterColor desiredColor)
    {
        colorAnimScript.SelectNewColor(currentColor,desiredColor);
        currentColor = desiredColor;
    }


    void Update()
    {
        ChangeSpriteGameObject();











        if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            switch(currentLevel)
            {
                case 1:
                switch (currentColor)
                {
                    case CharacterColor.Red: SwitchColor(CharacterColor.Blue); break;
                    case CharacterColor.Blue: SwitchColor(CharacterColor.Green); break;
                    case CharacterColor.Green: SwitchColor(CharacterColor.Red); break;
                }
                break;
                case 2:
                switch (currentColor)
                {
                    case CharacterColor.Red: SwitchColor(CharacterColor.Blue); break;
                    case CharacterColor.Blue: SwitchColor(CharacterColor.Green); break;
                    case CharacterColor.Green: SwitchColor(CharacterColor.Yellow); break;
                    case CharacterColor.Yellow: SwitchColor(CharacterColor.Red); break;

                }
                break;
                case 3:
                switch (currentColor)
                {
                    case CharacterColor.Red: SwitchColor(CharacterColor.Blue); break;
                    case CharacterColor.Blue: SwitchColor(CharacterColor.Green); break;
                    case CharacterColor.Green: SwitchColor(CharacterColor.Yellow); break;
                    case CharacterColor.Yellow: SwitchColor(CharacterColor.Purple); break;
                    case CharacterColor.Purple: SwitchColor(CharacterColor.Red); break;
                }
                break;
            }
            ChangeSpriteColor();
        }


    }

    void ChangeSpriteGameObject()
    {
        if(currentColor == CharacterColor.Red)
        {
            spritesperso[0].SetActive(true);
            spritesperso[1].SetActive(false);
            spritesperso[2].SetActive(false);
            spritesperso[3].SetActive(false);
            spritesperso[4].SetActive(false);
            transform.gameObject.tag = "Red";
        }
        if(currentColor == CharacterColor.Blue)
        {
            spritesperso[0].SetActive(false);
            spritesperso[1].SetActive(true);
            spritesperso[2].SetActive(false);
            spritesperso[3].SetActive(false);
            spritesperso[4].SetActive(false);
            transform.gameObject.tag = "Blue";
        }
        if(currentColor == CharacterColor.Green)
        {
            spritesperso[0].SetActive(false);
            spritesperso[1].SetActive(false);
            spritesperso[2].SetActive(true);
            spritesperso[3].SetActive(false);
            spritesperso[4].SetActive(false);
            transform.gameObject.tag = "Green";
        }
        if(currentColor == CharacterColor.Yellow)
        {
            spritesperso[0].SetActive(false);
            spritesperso[1].SetActive(false);
            spritesperso[2].SetActive(false);
            spritesperso[3].SetActive(true);
            spritesperso[4].SetActive(false);
            transform.gameObject.tag = "Yellow";
        }
        if(currentColor == CharacterColor.Purple)
        {
            spritesperso[0].SetActive(false);
            spritesperso[1].SetActive(false);
            spritesperso[2].SetActive(false);
            spritesperso[3].SetActive(false);
            spritesperso[4].SetActive(true);
            transform.gameObject.tag = "Purple";
        }
    }

    void ChangeSpriteColor()
    {
        /*switch(currentColor)
        {
            
            /*case CharacterColor.Red:  meshRenderer.material = materials[0]; transform.gameObject.tag = "Red"; break;
            case CharacterColor.Blue:  meshRenderer.material = materials[1]; transform.gameObject.tag = "Blue"; break;
            case CharacterColor.Green:  meshRenderer.material = materials[2]; transform.gameObject.tag = "Green"; break;
            case CharacterColor.Yellow:  meshRenderer.material = materials[3]; transform.gameObject.tag = "Yellow"; break;
            case CharacterColor.Purple:  meshRenderer.material = materials[4]; transform.gameObject.tag = "Purple"; break; 
        }*/

    }


    
}
    