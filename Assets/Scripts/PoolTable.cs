// public class PoolableObject : MonoBehaviour 
// {
//     private Transform player;
//     public float despawnDist = 20f;

//     void Start() => player = GameObject.FindWithTag("Player").transform;

//     void Update() 
//     {
//         // When it gets too far behind, just hide it.
//         // The Pool will now see this object as "available" because Active is false.
//         if (player.position.x - transform.position.x > despawnDist) 
//         {
//             gameObject.SetActive(false); 
//         }
//     }
// }