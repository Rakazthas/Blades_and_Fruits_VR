using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreDisplay : MonoBehaviour
{
    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "High Score/n";
        for(int i = 0; i < GlobalVars.bestScore.Count; i++)
        {
            scoreText.text += i + " : " + GlobalVars.bestScore[i] + "/n";
        }
    }
}
