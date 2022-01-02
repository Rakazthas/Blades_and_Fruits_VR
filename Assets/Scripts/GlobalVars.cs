using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVars : MonoBehaviour
{
    public static float time = 0.0f;
    public static int score = 0;
    public static int lives = 3;

    public static List<int> bestScore;

    public static bool inGame = false;

    private static bool invFrame = false;
    private float invTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        bestScore = new List<int>();

        for(int i = 0; i < 5; i++)
        {
            bestScore.Add(0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (inGame)
            time += Time.deltaTime;

        if (invFrame)
        {
            invTime += Time.deltaTime;
            if(invTime > 1)
            {
                invFrame = false;
                invTime = 0;
            }
        }

        if (lives == 0)
        {
            bestScore.Add(score);

            //TODO game over screen
            inGame = false;
            lives = 3;
        }
    }

    public static void Hurt()
    {
        if (!invFrame)
        {
            lives -= 1;
            invFrame = true;
        }
    }
}
