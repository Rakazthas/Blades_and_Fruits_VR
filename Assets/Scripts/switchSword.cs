using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchSword : MonoBehaviour
{
    public GameObject sword;
    public GameObject interactor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalVars.inGame)
        {
            sword.SetActive(true);
            interactor.SetActive(false);
        }
        else
        {
            sword.SetActive(false);
            interactor.SetActive(true);
        }
    }
}
