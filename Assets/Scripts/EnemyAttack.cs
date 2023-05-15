using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float speed = 5f;
    public float fireRate = 2f;
    public float destroyDelay = 2f; // tiempo de vida del proyectil
    private float nextFireTime;

    // Update is called once per frame
    void Update()
    {
        // Check if it's time to fire
        if (Time.time >= nextFireTime)
        {
            // Instantiate a new projectile object
            GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

            // Set the velocity of the projectile to move towards the left
            projectile.GetComponent<Rigidbody2D>().velocity = Vector2.left * 10f;

            // Destroy the projectile after the delay time
            Destroy(projectile, destroyDelay);

            // Update the next fire time
            nextFireTime = Time.time + fireRate;
        }
    }
}
