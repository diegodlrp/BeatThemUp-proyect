using UnityEngine;

public class ArcherController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 2f;
    public float stopDistance = 7f; // Archer stays at this range

    [Header("Combat Settings")]
    public GameObject arrowPrefab;
    public Transform firePoint; // Assign a child object at the bow's position
    public float fireRate = 2f;
    
    private float fireTimer;
    private Transform player;

    void Start()
    {
        // Finding the player by tag - ensure your Player object has the "Player" tag
        GameObject playerObj = GameObject.FindWithTag("Player");
        if (playerObj != null)
        {
            player = playerObj.transform;
        }
    }

    void Update()
    {
        if (player == null) return;

        float distance = Vector2.Distance(transform.position, player.position);

        // 1. Movement Logic: Move toward player until reaching stopDistance
        if (distance > stopDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
        }

        // 2. Shooting Logic
        fireTimer += Time.deltaTime;
        if (fireTimer >= fireRate)
        {
            Shoot();
            fireTimer = 0;
        }

        // Optional: Make the archer face the player
        FlipTowardsPlayer();
    }

    void Shoot()
    {
        if (arrowPrefab != null)
        {
            // Calculate direction to player
            Vector2 direction = (player.position - transform.position).normalized;
            
            // Calculate rotation so the arrow points at the player
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

            // Create the arrow
            Instantiate(arrowPrefab, firePoint.position, rotation);
            Debug.Log("Archer fires arrow!");
        }
    }

    void FlipTowardsPlayer()
    {
        if (player.position.x > transform.position.x)
            transform.localScale = new Vector3(1, 1, 1);
        else
            transform.localScale = new Vector3(-1, 1, 1);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, stopDistance);
    }
}