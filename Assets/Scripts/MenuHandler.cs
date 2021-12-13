using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHandler : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject scoreMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void goToScore()
    {
        mainMenu.SetActive(false);
        scoreMenu.SetActive(true);
    }

    public void goToMain()
    {
        mainMenu.SetActive(true);
        scoreMenu.SetActive(false);
    }

    public void play()
    {
        GlobalVars.inGame = true;
        mainMenu.SetActive(false);
        scoreMenu.SetActive(false);
    }

    public void quit()
    {
        Application.Quit();
    }
}
