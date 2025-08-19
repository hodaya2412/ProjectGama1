using UnityEngine;

public class Example : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed;
    float directionX;

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
        directionX = Input.GetAxis("Horizontal");
        
    }

    private void FixedUpdate()
    {
   
        rb.linearVelocity = new(directionX * speed, rb.linearVelocity.y);
    
}
}
