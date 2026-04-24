// To handle an "endless swarm" for special occasions, you need a Spawner Mode. Instead of following your "shopping list" (the ScriptableObject), this mode will just pump out enemies at a set interval and place them just outside the screen.

// Since you are a "speeding motorbike," it's best to spawn them ahead of the player so they appear as if they are waiting in ambush, or behind the player if they are "chasing" you.
// 1. The Swarm Controller

// Create a new script called SwarmManager. This will act like a toggle switch for your endless waves.
// C#

// using UnityEngine;

// public class SwarmManager : MonoBehaviour
// {
//     public GameObject knightPrefab;
//     public GameObject archerPrefab;
//     public Transform player;

//     [Header("Settings")]
//     public bool isSwarmActive = false;
//     public float spawnRate = 2f; // New enemy every 2 seconds
//     public float spawnDistanceX = 20f; // Distance ahead of player
    
//     private float timer;

//     void Update()
//     {
//         if (!isSwarmActive) return;

//         timer += Time.deltaTime;

//         if (timer >= spawnRate)
//         {
//             SpawnSwarmEnemy();
//             timer = 0;
//         }
//     }

//     void SpawnSwarmEnemy()
//     {
//         // Randomly pick between Knight and Archer
//         GameObject prefabToSpawn = (Random.value > 0.5f) ? knightPrefab : archerPrefab;

//         // Position: Player X + Spawn Distance, and a random height for variety
//         float spawnX = player.position.x + spawnDistanceX;
//         float spawnY = Random.Range(-1f, 1f); // Adjust based on your road height

//         Vector3 spawnPos = new Vector3(spawnX, spawnY, 0);
        
//         Instantiate(prefabToSpawn, spawnPos, Quaternion.identity);
//     }
// }

// 2. Making the Swarm "Smart"

// If you spawn 50 enemies, they will eventually lag the game. Since these are "Swarm" enemies, they need to be aggressive but also clean themselves up.

// Add this logic to your Knight and Archer scripts:
// Make sure they have the Despawner logic we discussed earlier. If the player drives past a swarm member and they are 20 meters behind, they must Destroy or Deactivate themselves so they don't eat up your memory.
// 3. Triggering the Event

// You can trigger this "Special Occasion" in two ways:

//     By Distance: Inside your Update, check if player.position.x > 500. If yes, set isSwarmActive = true.

//     By Trigger Zone: Place a large invisible box in your level. When the player enters it, it tells the SwarmManager to start.

// 4. Gameplay Tip: The "Pressure" Mechanic

// Because your Fuel is constantly draining, a swarm is a double threat:

//     The Knights force you to slow down or maneuver (consuming more fuel if you accelerate to dodge).

//     The Archers chip away at your health, forcing you to use the Heal (which costs massive fuel).

// If you want the swarm to feel truly endless, you should slightly increase the spawnRate over time (e.g., spawnRate -= 0.01f every second) until the player reaches a "Safe Zone."
// Summary of Workflow

//     Create the Manager: Use the script above.

//     Assign Prefabs: Drag your Knight and Archer into the slots.

//     Clean up: Ensure the enemies have a script to disappear once they are far behind the player.

// Would you like the Archer's arrow script next so they can actually "swarm" you with projectiles?