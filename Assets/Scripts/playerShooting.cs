using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShooting : MonoBehaviour
{
    public GameObject laserPrefab;
    public float firedelay = 0.25f;
    float cooldownTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {// allows player to shoot when the space bar is pressed. 
        cooldownTimer -= Time.deltaTime;
        if( Input.GetButton("Fire1") && cooldownTimer <= 0)
        {
            Debug.Log("pew!");
                cooldownTimer = firedelay;
            Instantiate(laserPrefab, transform.position,transform.rotation);
        }
    }
}
