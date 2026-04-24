using UnityEngine;

[System.Serializable] 
public class ObstaclePlacement
{
    public string obstacleTag; // "Crack", "Barricade", or "Enemy"
    public float xPos;         // How far down the road
    public float yPos;         // How high up (0 for ground)
}

[CreateAssetMenu(fileName = "NewLevel", menuName = "Game/Level Data")]
public class LevelData : ScriptableObject
{
    public ObstaclePlacement[] obstacles;
}