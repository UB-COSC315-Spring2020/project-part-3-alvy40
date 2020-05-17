using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserMove : MonoBehaviour
{
    float laserSpeed = 5f;

    // Update is called once per frame
    void Update()
    {// Allows lasers and Missiles to move as needed
        Vector3 pos = transform.position;
        
        Vector3 velocity = new Vector3(0, laserSpeed * Time.deltaTime, 0);
        
        pos += transform.rotation * velocity;

        transform.position = pos;
    }
}
