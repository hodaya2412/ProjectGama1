using UnityEngine;

public class MoveTarget : MonoBehaviour
{
    private bool isSpecial = false;          
    private float horizontalRange = 1f;      
    private float movementSpeed = 2f;        
    private float ChanceToBeSpeical = 0.2f;
    private float startingX;

    void Start()
    {
        startingX = transform.position.x;

        
        isSpecial = (Random.value < ChanceToBeSpeical); 
    }

    void Update()
    {
        if (isSpecial)
        {
            float horizontalOffset = Mathf.Sin(Time.time * movementSpeed) * horizontalRange;
            transform.position = new Vector2(startingX + horizontalOffset, transform.position.y);
        }
    }
}
