using System.Collections;
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            StartCoroutine(BlinkBeforeDestroy());
        }
    }

    IEnumerator BlinkBeforeDestroy()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        for (int i = 0; i < 3; i++)
        {
            sr.enabled = false;
            yield return new WaitForSeconds(delayForDestroy);
            sr.enabled = true;
            yield return new WaitForSeconds(delayForDestroy);
        }
        Destroy(gameObject);
    }

}
