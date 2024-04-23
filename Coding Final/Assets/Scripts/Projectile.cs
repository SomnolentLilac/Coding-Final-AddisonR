using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    private int damage = 10;

    public void SetDamage(int newDamage)
    {
        damage = newDamage;
    }

    void Update()
    {
        //code for making the projectiles go forwards
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
    }

    private void OnTriggerEnter(Collider other)
    {
        //destroys objects after they hit the player and ensures the health gets updated
            Health playerHealth = other.GetComponent<Health>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
            }
            Destroy(gameObject); //Feedback: Good opportunity to use object pooling from the software design patterns lesson.

    }
}
