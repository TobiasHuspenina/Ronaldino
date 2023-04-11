using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;
    private Vector3 defaultPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        defaultPosition = transform.position;
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
    public void SetDefaultPosition()
    {
        transform.position = defaultPosition;
    }
    private void OnTriggerEnter(Collider other)
    {
        // Pokud se objekt s tagem "Mic" dotkne objektù s tagem "CheckBox1" a "CheckBox2",
        // míèek se vrátí na výchozí pozici
        if (other.CompareTag("CheckBox1") || other.CompareTag("CheckBox2"))
        {
            SetDefaultPosition();
        }
    }
}
