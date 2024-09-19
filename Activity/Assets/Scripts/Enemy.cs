using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Health health;

    void Awake()
    {
        health = GetComponent<Health>();
        if (health == null)
        {
            Debug.LogError("Health component not found!");
        }
    }

    public void TakeDamage(float damage)
    {
        health.TakeDamage(damage);
        if (health.CurrentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Trigger death animations, sound effects, etc.
        // Example: PlayDeathAnimation();
        Destroy(gameObject);
    }
}

