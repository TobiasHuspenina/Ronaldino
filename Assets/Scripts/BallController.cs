using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            Vector2 direction = transform.position - collision.gameObject.transform.position;
            rb.AddForce(direction.normalized * speed, ForceMode2D.Impulse);
        }
        if (collision.gameObject.CompareTag("Player2"))
        {
            Vector2 direction = transform.position - collision.gameObject.transform.position;
            rb.AddForce(direction.normalized * speed, ForceMode2D.Impulse);
        }
    }
}
