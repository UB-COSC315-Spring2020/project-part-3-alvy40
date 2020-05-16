using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipSpawn : MonoBehaviour
{
    public GameObject shipPlayerPrefab;
    GameObject playerInstance;

    float spawnTime;

    // Start is called before the first frame update
    void Start()
    {
        playerSpawn();
    }

    void playerSpawn()
    {
        spawnTime = 1;
        playerInstance = (GameObject)Instantiate(shipPlayerPrefab, transform.position, Quaternion.identity);
        playerInstance.name = "The fighter";
    }

    // Update is called once per frame
    void Update()
    {
       if(playerInstance == null)
        {
            spawnTime -= Time.deltaTime;
            
            if(spawnTime <= 0)
            {
                playerSpawn();
            }
        } 
    }
}
