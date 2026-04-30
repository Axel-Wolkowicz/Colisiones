using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Contador : MonoBehaviour
{
    public TextMeshProUGUI txtScore;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
