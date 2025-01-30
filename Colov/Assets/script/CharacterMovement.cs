using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.Audio;

public class CharacterMovement : MonoBehaviour
{
    public GameObject arrowDisappear;
    public GameObject wheelDisappear;
    public int speed = 3;
    ChangeColor colorScript => GetComponent<ChangeColor>();
    ChangeColor speedlevelScript => GetComponent<ChangeColor>();
    public DeathScript deathScript;
    private bool success;
    public bool invincible =false;
    float timeDeath = 1.2f;


    public AudioSource audioSource;
    public AudioClip Death;

    void Start()
    {
        Time.timeScale = 1f;
    }

        IEnumerator Timerdeath()
    {
        yield return new WaitForSeconds(timeDeath);
        deathScript.Mort();

    }
    void Update()
    {
        Vector3 scrolling = Vector3.zero;
        scrolling.x = speed;

        Vector3 movement = scrolling * Time.deltaTime;
        transform.Translate(movement);

        if( Input.GetKeyDown(KeyCode.I))
        {
            invincible = !invincible;
        }
        if( Input.GetKeyDown(KeyCode.T))
        {
            if( Time.timeScale >1f) Time.timeScale = 1f ; else Time.timeScale = 3f ;
        }
        if( Input.GetKey(KeyCode.LeftControl))
        {
            if (Input.GetKeyDown(KeyCode.Keypad1)) {SceneManager.LoadScene("Game_Scene_LVL1");}
            if (Input.GetKeyDown(KeyCode.Keypad2)) {SceneManager.LoadScene("Game_Scene_LVL2");}  
            if (Input.GetKeyDown(KeyCode.Keypad3)) {SceneManager.LoadScene("Game_Scene_LVL3");}      
        }

       /* switch(speedlevelScript.currentLevel)
        {
            case 1: speed = 3; break;
            case 2: speed = 6; break;
            case 3: speed = 9; break;
        }*/
    }

    void PlayParticle(Collider other)
    {
        //other.GetComponentInChildren<ParticleSystem>().Play();
    }

    void OnTriggerEnter(Collider other)
    {
     Debug.Log(other.name);
     if( invincible == false)
          switch(other.tag)
          {
               default: break;
               case "RedObstacle": if (colorScript.currentColor!=ChangeColor.CharacterColor.Red) {Debug.Log("Tu es Mort par Red"); Mortn();} break;
               case "BlueObstacle": if (colorScript.currentColor!=ChangeColor.CharacterColor.Blue) {Debug.Log("Tu es Mort par Blue"); Mortn();} break;
               case "GreenObstacle": if (colorScript.currentColor!=ChangeColor.CharacterColor.Green) {Debug.Log("Tu es Mort par Green"); Mortn();} break;
               case "YellowObstacle": if (colorScript.currentColor!=ChangeColor.CharacterColor.Yellow) {Debug.Log("Tu es Mort par Yellow"); Mortn();} break;
               case "PurpleObstacle": if (colorScript.currentColor!=ChangeColor.CharacterColor.Purple) {Debug.Log("Tu es Mort par Purple"); Mortn();} break;
          }
        
        if (transform.gameObject.tag == "Red" && other.CompareTag ("RedObstacle"))
        {
            SoundManager.PlaySound(SoundType.GoodObstacle);
            PlayParticle(other);
        }
        if (transform.gameObject.tag == "Blue" && other.CompareTag ("BlueObstacle"))
        {
            SoundManager.PlaySound(SoundType.GoodObstacle);
            PlayParticle(other);
        }
        if (transform.gameObject.tag == "Green" && other.CompareTag ("GreenObstacle"))
        {
            SoundManager.PlaySound(SoundType.GoodObstacle);
            PlayParticle(other);
        }
        if (transform.gameObject.tag == "Yellow" && other.CompareTag ("YellowObstacle"))
        {
            SoundManager.PlaySound(SoundType.GoodObstacle);
            PlayParticle(other);
        }
        if (transform.gameObject.tag == "Purple" && other.CompareTag ("PurpleObstacle"))
        {
            SoundManager.PlaySound(SoundType.GoodObstacle);
            PlayParticle(other);
        }
    }


    void Mortn()
    {
        audioSource.PlayOneShot(Death);
        speed = 0;
        arrowDisappear.transform.parent = null;
        Destroy(arrowDisappear.gameObject);
        wheelDisappear.transform.parent = null;
        Destroy(wheelDisappear.gameObject);
        StartCoroutine(Timerdeath());
        transform.Find("Graphics").DOScaleY(0.2f, 0.3f); 
        
    }

}