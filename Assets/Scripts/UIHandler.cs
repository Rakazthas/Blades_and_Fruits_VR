using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public Text textLives;
    public Text textTimer;
    public Text textScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textLives.text = "Lives : " + GlobalVars.lives;
        textTimer.text = "Time : " + (((int)GlobalVars.time)/60) + " : " + ((float)Mathf.Round((GlobalVars.time%60)*1000f)/1000f);
        textScore.text = "Score : " + GlobalVars.score;
    }
}
