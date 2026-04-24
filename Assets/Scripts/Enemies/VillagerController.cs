using UnityEngine;
using System.Collections;

public class VillagerController : MonoBehaviour
{
    [Header("Movimiento")]
    public float moveSpeed = 2f;
    public float roamRadius = 5f;
    [SerializeField] float waitTime = 0.5f;

    [Header("Límites Verticales (Endless Scroller)")]
    [SerializeField] float minY = -9f;
    [SerializeField] float maxY = 3.7f;

    private Vector2 targetPosition;
    private bool isWaiting = false;

    void Start()
    {
        // Inicializamos el primer objetivo
        PickNewTarget();
    }

    void Update()
    {
        if (isWaiting) return;

        // Movimiento suave hacia el objetivo
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        // Si llega al objetivo, espera un momento y busca uno nuevo
        if (Vector2.Distance(transform.position, targetPosition) < 0.1f)
        {
            StartCoroutine(WaitAndMove());
        }
    }

    void PickNewTarget()
    {
        // Calculamos un punto aleatorio alrededor de la posición actual
        Vector2 randomPoint = (Vector2)transform.position + Random.insideUnitCircle * roamRadius;

        // Mantenemos la X libre para el scroller, pero limitamos la Y
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

    // Dibujamos los límites en el Editor para que sea fácil de ajustar
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Vector3 leftPoint = new Vector3(transform.position.x - 5, minY, 0);
        Vector3 rightPoint = new Vector3(transform.position.x + 5, maxY, 0);
        
        // Dibuja dos líneas horizontales que representan el "camino" permitido
        Gizmos.DrawLine(new Vector3(-100, minY, 0), new Vector3(100, minY, 0));
        Gizmos.DrawLine(new Vector3(-100, maxY, 0), new Vector3(100, maxY, 0));
    }
}