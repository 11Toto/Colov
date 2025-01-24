using UnityEngine;

public class CameraStop : MonoBehaviour
{

    void OnTriggerEnter (Collider other)
    {
        if (other.transform.gameObject.tag == "TriggerCamera")
        {
            Camera.main.transform.parent = null;
        }
    }
}
