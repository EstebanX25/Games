using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
  
{
    public float moveSpeed = 5f;
    public float changeDirectionInterval = 2f;


    private Rigidbody2D rb;
    private float timer;
    private Vector2[] directions = { Vector2.up, Vector2.down, Vector2.left, Vector2.right };

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        timer = changeDirectionInterval;
    }

    private void FixedUpdate()
    {
        timer -= Time.fixedDeltaTime;

        if (timer <= 0f)
        {
            MoveRandomDirection();
            timer = changeDirectionInterval;
        }
    }

    private void MoveRandomDirection()
    {
        int randomIndex = Random.Range(0, directions.Length);
        Vector2 randomDirection = directions[randomIndex];
        rb.velocity = randomDirection.normalized * moveSpeed;
    }
}


