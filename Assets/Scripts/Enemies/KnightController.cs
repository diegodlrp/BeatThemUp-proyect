using UnityEngine;
using System.Collections;
public class KnightController : MonoBehaviour
{
    [Header("Movimiento Aleatorio")]
    public float moveSpeed = 2f;
    public float chaseSpeed = 4f;
    public float roamRadius = 5f;
    public float waitTime = 1f;

    [Header("Límites Verticales")]
    [SerializeField] float minY = -9f;
    [SerializeField] float maxY = 3.7f;

    [Header("Detección")]
    public float detectionRange = 6f;
    public float attackRange = 1.5f;
    
    private Vector2 targetPosition;
    private bool isWaiting = false;
    private Transform player;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        PickNewTarget();
    }

    void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer <= detectionRange)
        {
            // MODO PERSECUCIÓN
            StopAllCoroutines(); 
            isWaiting = false;
            
            if (distanceToPlayer > attackRange)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, chaseSpeed * Time.deltaTime);
            }
            else
            {
                Debug.Log("¡Caballero Ataca!");
            }
        }
        else
        {
            // MODO ALDEANO (Patrulla Random)
            if (isWaiting) return;

            transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            if (Vector2.Distance(transform.position, targetPosition) < 0.1f)
            {
                StartCoroutine(WaitAndMove());
            }
        }
    }

    void PickNewTarget()
    {
        Vector2 randomPoint = (Vector2)transform.position + Random.insideUnitCircle * roamRadius;
        float clampedY = Mathf.Clamp(randomPoint.y, minY, maxY);
        targetPosition = new Vector2(randomPoint.x, clampedY);
    }

    IEnumerator WaitAndMove()
    {
        isWaiting = true;
        yield return new WaitForSeconds(waitTime);
        PickNewTarget();
        isWaiting = false;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRange);
    }
}
