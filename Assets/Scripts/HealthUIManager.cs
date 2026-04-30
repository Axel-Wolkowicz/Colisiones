using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthUIManager : MonoBehaviour
{
    public int health = 3;
    public TextMeshProUGUI lifeScore;
    // Start is called before the first frame update
    void Start()
    {
        lifeScore.text = health.ToString();
    }
    public void ReduceLife(){
        health --;
        lifeScore.text = health.ToString();
        if(health <= 0){
            lifeScore.text = "Perdiste";
        }
    }
}
