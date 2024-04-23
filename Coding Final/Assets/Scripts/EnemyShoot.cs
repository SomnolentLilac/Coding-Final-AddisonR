using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
   [SerializeField] GameObject projectilePrefab;
   [SerializeField] Transform shootPoint;
   [SerializeField] float shootInterval = 1f;
   [SerializeField] int damage = 10;

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
        GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity); //Feedback: Good opportunity to use object pooling from the software design patterns lesson.
        Projectile projectileComponent = projectile.GetComponent<Projectile>();
        if (projectileComponent != null)
        {
            projectileComponent.SetDamage(damage);
        }
    }
}
