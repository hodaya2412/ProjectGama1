using System;
using UnityEngine;

public class Ball_Scripts : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float jumpSpeed;
    [SerializeField] float MaxBoundsX;
    float PushLeft = -1f;
    float PushRight = 1f;
    float horizontalPushFromWall = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody is null!");
        }
        
    }

    // Update is called once per frame
    void Update()
    {


        }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Board"))
        {
            Jump(other);
        }


        if (other.gameObject.CompareTag("Lava"))
        {
            GameOverLose();

        }
        
        if (other.gameObject.CompareTag("Wall"))
            {
                PushBallAwayFromWall(other);
            }

    }

    private void PushBallAwayFromWall(Collision2D other)
    {
        float pushDirection = transform.position.x < other.transform.position.x ? PushLeft : PushRight;

        rb.linearVelocity = new Vector2(pushDirection * horizontalPushFromWall, rb.linearVelocity.y);
    }

    private void Jump(Collision2D other)
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpSpeed);
    }

     private void GameOverLose()
    {
        Debug.Log("Game is Over");
    }
}
