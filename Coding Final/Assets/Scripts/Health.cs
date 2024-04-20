using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    

    private void Start()
    {
        currentHealth = maxHealth;
        Debug.Log(currentHealth);
        //makes sure the health is actually at 100 when starting
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        

        Debug.Log(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }


    void Die()
    {
        // tells you if you died
        Debug.Log("Player has died.");
        
    }

    
}