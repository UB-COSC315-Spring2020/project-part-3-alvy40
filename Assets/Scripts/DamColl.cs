using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class DamColl : MonoBehaviour
{
    // varibles for enemy ship
    int enemyShip = 1;
    int enemyPoints;
    public Text  Score;

    private void Start()
    {
        Score.text = "Score";
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        //  enemy ship loses helth
        //Debug.Log("Working");
        enemyShip--;

        if (enemyShip <= 0)
        {
            Die();
            enemyPoints = 20;
            Score.text = "Score " + enemyPoints.ToString();
        }

       
    }
    // Enemy ship is destoryed and points are assigned 
    void Die()
    {
        Destroy(gameObject);
        
        
    }

}
