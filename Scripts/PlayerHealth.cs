using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{// players helath
    int healthShip = 3;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Working");
        healthShip--;
        // -1 health for each hit.
    }

    private void Update()
    {
        if (healthShip <= 0)
        {
            Die();
        }
    }

    void Die()
    {// when player is out of lives return to main menu
        Destroy(gameObject);
        SceneManager.LoadScene("MainMenu");
    }
}
