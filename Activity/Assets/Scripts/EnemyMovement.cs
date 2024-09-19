using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;          // Speed of the enemy movement
    public float moveDistance = 3f;   // Distance to move back and forth
    private Vector3 startPosition;     // Starting position of the enemy
    private bool movingRight = true;   // Direction flag

    void Start()
    {
        startPosition = transform.position; // Store the starting position
    }

    void Update()
    {
        // Move the enemy
        if (movingRight)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;

            // Check if the enemy reached the move distance
            if (transform.position.x >= startPosition.x + moveDistance)
            {
                movingRight = false; // Change direction
            }
        }
        else
        {
            transform.position -= Vector3.right * speed * Time.deltaTime;

            // Check if the enemy reached the starting position
            if (transform.position.x <= startPosition.x - moveDistance)
            {
                movingRight = true; // Change direction
            }
        }
    }
}

