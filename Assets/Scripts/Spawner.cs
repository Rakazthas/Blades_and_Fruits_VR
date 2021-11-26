using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float baseFrequency = 0.5f;
    public float diffChangeTimer = 10;

    public float bombBaseProba = 0.2f;

    public int maxNbObjects = 4;

    public float fruitSpeed = 2.0f;

    public GameObject[] fruitsPrefabs;
    public GameObject bombPrefab;


    private float timer;
    private float diffTimer;
    private int listSize = 0;

    private int currDiff = 1;

    // Start is called before the first frame update
    void Start()
    {
        listSize = fruitsPrefabs.Length;
        timer = 1 / (baseFrequency * currDiff);
        diffTimer = diffChangeTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        diffTimer -= Time.deltaTime;

        if(timer <= 0)
        {
            timer = 1 / (baseFrequency * currDiff);
            int nbObjects = Random.Range(1, maxNbObjects +1);

            for(int i = 0; i < nbObjects; i++)
            {
                Vector3 start = transform.position;

                int typeFruit = Random.Range(0, listSize);
                GameObject fruit = Instantiate(fruitsPrefabs[typeFruit], start, transform.rotation * Quaternion.Euler(0, -90, 0)); // a ajuster via tests

                fruit.GetComponent<Rigidbody>().velocity = new Vector3(fruitSpeed, 0.0f, 0.0f);
                
            }

            if(Random.Range(0.0f, 1.0f) < bombBaseProba && bombPrefab != null)
            {
                Vector3 start = transform.position;

                GameObject bomb = Instantiate(bombPrefab, start, transform.rotation * Quaternion.Euler(0, -90, 0)); // a ajuster via tests

                bomb.GetComponent<Rigidbody>().velocity = new Vector3(fruitSpeed, 0.0f, 0.0f);
            }
        }

        if(diffTimer <= 0)
        {
            diffTimer = diffChangeTimer;
            currDiff += 1;
        }
    }
}
