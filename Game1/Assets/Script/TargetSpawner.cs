using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    Rigidbody2D rb;
    float delayForDestroy = 0.1f;
    //[SerializeField] bool isSpecial = true;
    //private float horizontalMovementRange =1f; 
    //private float MovementSpeed = 2f;
    //private float startingX;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D is null!");
        }

        //startingX = transform.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        //if (isSpecial)
        //{
        //    float horizontalOffset = Mathf.Sin(Time.time * MovementSpeed) * horizontalMovementRange;

        //    transform.position = new Vector2(startingX + horizontalOffset, transform.position.y);

        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject, delayForDestroy);
        }

    }
}
