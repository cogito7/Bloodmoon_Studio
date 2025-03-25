using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int startHealth = 5;
    private int currentHealth;

    void Start()
    {
        currentHealth = startHealth;  // Initialize health to max or start health
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Enemy took " + damage + " damage. Remaining HP: " + currentHealth);

        if (currentHealth <= 0)
        {
            Debug.Log("Enemy defeated!");
            Destroy(gameObject); // Destroy the enemy
        }
    }

}
