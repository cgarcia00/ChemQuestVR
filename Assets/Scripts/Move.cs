using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject cube;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -5)
        {
            Destroy(cube);
        }
        transform.position -= new Vector3(0, 0, 3 * Time.deltaTime);
    }
}
