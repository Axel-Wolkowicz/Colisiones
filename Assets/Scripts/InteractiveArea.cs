using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveArea : MonoBehaviour
{
   void OnCollisionEnter(Collision col){
    if (col.gameObject.CompareTag("pickable")){
        Destroy(col.gameObject);
    }
   }
}
