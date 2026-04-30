using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveArea : MonoBehaviour
{
    public Contador scoreUIMgr;
    public HealthUIManager hurt;
   void OnCollisionEnter(Collision col){
    if (col.gameObject.CompareTag("pickable")){
        Destroy(col.gameObject);
        scoreUIMgr.AddPointAndUpdateScore();
    }
    if (col.gameObject.CompareTag("hurt")){
        Destroy(col.gameObject);
        hurt.ReduceLife();
    }
   }
}
