using UnityEngine;

public class CollisionController : MonoBehaviour
{
    private PlayerStatsController playerStats;

    void Awake()
    {
        // Automatically find the stats script on the same object
        playerStats = GetComponent<PlayerStatsController>();

        // Good practice: check if it actually found it
        if (playerStats == null)
        {
            Debug.LogError("CollisionController couldn't find PlayerStatsController on " + gameObject.name);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Cracks"))
        {
            playerStats.HandleCollision("Crack");
        } 
        else if (other.CompareTag("Barricade"))
        {
            playerStats.HandleCollision("Barricade");
        }
    }

}
