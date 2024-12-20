
using System;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class ChangeColor : MonoBehaviour
{
    public Material[] materials;
    public MeshRenderer meshRenderer;
    int currentLevel = 0;
    public enum CharacterColor{Red, Blue,Green,Yellow,Purple}
    public CharacterColor currentColor = CharacterColor.Red;

    void Start()
    {
        SwitchColor(CharacterColor.Red);
    }

    
    void OnTriggerEnter(Collider other)
    {
        switch(other.gameObject.tag)
            {
                case "Niveau1":currentLevel=1; break;
                case "Niveau2":currentLevel=2; break;
                case "Niveau3":currentLevel=3; break;
            }
    }

    void ChangeTagColor()
    {
        
    }

    void SwitchColor(CharacterColor desiredColor)
    {
        currentColor = desiredColor;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
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
                    case CharacterColor.Green: SwitchColor(CharacterColor.Red); break;

                }
                break;
                case 3:
                switch (currentColor)
                {
                    case CharacterColor.Red: SwitchColor(CharacterColor.Blue); break;
                    case CharacterColor.Blue: SwitchColor(CharacterColor.Green); break;
                    case CharacterColor.Green: SwitchColor(CharacterColor.Red); break;
                }
                break;
            }
            ChangeSpriteColor();
        }
    }

    void ChangeSpriteColor()
    {
        switch(currentColor)
        {
            case CharacterColor.Red:  meshRenderer.material = materials[0]; break;
            case CharacterColor.Blue:  meshRenderer.material = materials[1]; break;
            case CharacterColor.Green:  meshRenderer.material = materials[2]; break;
            case CharacterColor.Yellow:  meshRenderer.material = materials[3]; break;
            case CharacterColor.Purple:  meshRenderer.material = materials[4]; break; 
        }
    }

    
}
    