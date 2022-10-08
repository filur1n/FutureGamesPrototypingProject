using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    private int currentHealth;

    public int deathCount;



    void Start()
    {
        currentHealth = health;
        deathCount = 0;
    }



    void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            deathCount++;

          
        }

        if (deathCount >= 3)
        {
            SceneManager.LoadScene("Level");
            Debug.LogError("Should change the scene");
        }
    }



    public void HurtEnemy(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
