using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;
    private int damage = 10;

    public void SetDamage(int newDamage)
    {
        damage = newDamage;
    }

    void Update()
    {
        //code for making the projectiles go forwards
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
            Health playerHealth = other.GetComponent<Health>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
            }
            Destroy(gameObject);
        //destroys objects after they hit the player and ensures the health gets updated
    }
}
