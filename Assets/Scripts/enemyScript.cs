using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public GameObject laserPrefab;
    public float firedelay = 0.50f;
    float cooldownTimer = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { // allows enemy ship s to shoot prefab.
        cooldownTimer -= Time.deltaTime;
        if ( cooldownTimer <= 0)
        {
            //Debug.Log("pew!");
            cooldownTimer = firedelay;
            Instantiate(laserPrefab, transform.position, transform.rotation);
        }
    }
}

