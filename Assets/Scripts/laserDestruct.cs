using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserDestruct : MonoBehaviour
{
    public float timer = 2f;

    // Update is called once per frame
    void Update()
    { // destroys prefabs laser and missiles 
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }
}
