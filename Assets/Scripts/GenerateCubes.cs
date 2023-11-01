using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCubes : MonoBehaviour
{
    public GameObject blueCube;
    public GameObject redCube;
    private float timeLeft = 1.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = 1.0f;
            GenerateCube();
        }
    }

    void GenerateCube()
    {
        if (Random.value > 0.5f)
        {
            GameObject newObj = Instantiate(blueCube, new Vector3(Random.Range(-1, 2), Random.Range(-1.5f, 1.5f), 5), 
         new Quaternion(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1)));
        } else
        {
            GameObject newObj = Instantiate(redCube, new Vector3(Random.Range(-1, 2), Random.Range(-1.5f, 1.5f), 5), 
                new Quaternion(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1)));
        }
    }

}
