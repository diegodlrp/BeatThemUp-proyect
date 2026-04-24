using UnityEngine;

public class ArrowController : MonoBehaviour
{
public float speed = 10f;
    public float lifetime = 3f;

    void Start() => Destroy(gameObject, lifetime); // Cleanup to save memory

    void Update()
    {
        // Move in the direction the arrow is facing (Right is the X-axis in 2D)
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Logic for damaging the player goes here
            Destroy(gameObject); 
        }
    }
}
