// public class Despawner : MonoBehaviour
// {
//     private Transform playerTransform;
//     public float despawnDistance = 15f; // Distance behind player to deactivate

//     void Start()
//     {
//         playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
//     }

//     void Update()
//     {
//         // If the player has passed the object by more than the despawnDistance
//         if (playerTransform.position.x - transform.position.x > despawnDistance)
//         {
//             gameObject.SetActive(false); // Put it back in the "bucket" (Pool)
//         }
//     }
// }