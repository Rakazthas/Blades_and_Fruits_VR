using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSliced : MonoBehaviour
{
    public float fruitValue = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sword"))
        {
            GlobalVars.score += fruitValue;
        }
    }
}
