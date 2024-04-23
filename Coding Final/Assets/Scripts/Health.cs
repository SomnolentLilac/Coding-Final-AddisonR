#define DEBUG_MODE //This is a preprocessor. Comment this line to disable debugs at runtime.

//delete unused  namespaces
using System.Collections; //unused namespace
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int maxHealth = 100; // Feedback: Serialized for visibility and editing in the Editor, allowing game designers to adjust it based on design choices.
    private int currentHealth; // Feedback: Make the accessor private since it's only modified within this script. If intended for modification from outside the class, use Properties.

    private void Start()
    {
        // Feedback: Comments usually go before a block of code or next to single code lines, not below.
        // Feedback: Once you've confirmed it's working, consider deleting, disabling, or commenting out debug logs. You can use preprocessors, as I did in this script.

        currentHealth = maxHealth; // Ensures health is at 100 when starting.
        #if DEBUG_MODE
        Debug.Log(currentHealth);
        #endif
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        #if DEBUG_MODE
        Debug.Log(currentHealth); 
        #endif

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Feedback: I would expect some sort of implementation here, like disappearing the player or displaying a game over screen, for example.
        // Indicates the player has died.
        #if DEBUG_MODE
        Debug.Log("Player has died."); 
        #endif
    }
}
