using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    Rigidbody2D rb;
    float delayForDestroy = 0.1f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D is null!");
        }

       

    }

    void Update()
    {
    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject, delayForDestroy);
        }

    }
}
