using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform shootPoint;
    public float shootInterval = 1f;
    public int damage = 10;

    private float shootTimer = 0f;

    private void Update()
    {
        //all the code for determining the shooting timing
        if (shootTimer <= 0)
        {
            Shoot();
            shootTimer = shootInterval;
        }
        else
        {
            shootTimer -= Time.deltaTime;
        }
    }

    void Shoot()
    {
        //creates a copy of the projectile prefab and sets the damage it'll do to the player
        GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
        Projectile projectileComponent = projectile.GetComponent<Projectile>();
        if (projectileComponent != null)
        {
            projectileComponent.SetDamage(damage);
        }
    }
}
