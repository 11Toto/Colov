using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDisappear : MonoBehaviour
{

        public GameObject Arrow;

   void OnTriggerEnter(Collider other)
   {
     if(other.gameObject.transform.tag == "TriggerCamera")
     {
        Arrow.transform.parent = null;
        Destroy(Arrow.gameObject);
     }
   }
}
