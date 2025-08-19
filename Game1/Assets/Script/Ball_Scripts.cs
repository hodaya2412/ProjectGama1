using System;
using UnityEngine;

public class Ball_Scripts : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float jumpSpeed;
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
            Jump();
        }

        if (other.gameObject.CompareTag("Lava"))
        {
            GameOver();

        }

    }

    private void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpSpeed);

    }

     private void GameOver()
    {
        Debug.Log("Game is Over");
    }
}
