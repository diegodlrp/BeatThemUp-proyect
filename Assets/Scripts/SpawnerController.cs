// using UnityEngine;

// public class Spawner : MonoBehaviour
// {
//     public LevelData levelData;    // Your "Shopping List" file
//     public Transform player;       // Drag your Player here
//     public float lookAhead = 20f;  // How far off-screen to spawn

//     private int nextIndex = 0;     // Which list item are we waiting for?

//     void Update()
//     {
//         // 1. Check if we still have items left in the list
//         if (nextIndex < levelData.obstacles.Length)
//         {
//             // 2. Get the data for the next obstacle
//             var nextObstacle = levelData.obstacles[nextIndex];

//             // 3. Is the player close enough to the next X position?
//             if (player.position.x + lookAhead >= nextObstacle.xPos)
//             {
//                 SpawnObject(nextObstacle);
//                 nextIndex++; // Move to the next item on the shopping list
//             }
//         }
//     }

//     void SpawnObject(ObstaclePlacement data)
//     {
//         // For now, we will just use Instantiate. 
//         // Later, you replace this with "Object Pooling" to save memory.
//         GameObject prefab = GetPrefabByType(data.obstacleTag);
//         Vector3 position = new Vector3(data.xPos, data.yPos, 0);
        
//         Instantiate(prefab, position, Quaternion.identity);
//         Debug.Log("Spawned " + data.obstacleTag + " at " + data.xPos);
//     }

//     GameObject GetPrefabByType(string tag)
//     {
//         // This is where you'd link your "Crack" or "Barricade" prefabs
//         // Logic: if (tag == "Crack") return crackPrefab;
//         return null; 
//     }
// }