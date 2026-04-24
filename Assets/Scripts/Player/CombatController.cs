using System.Runtime.CompilerServices;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    private PlayerStatsController playerStats;

    [Header("Magic Attack Settings")]
    [SerializeField] private float magicAttackFuelCost = 80f;
    [SerializeField] private float magicAttackCooldown = 5f;
    private float magicAttackCooldownTimmer = 0f;

    [Header("Magic Healing Settings")]
    [SerializeField] private float magicHealingBaseFuelCost = 10f;
    [SerializeField] private float magicHealingIncreaseRateFuelCost = 15f;
    [SerializeField] private float magicHealingAmount = 5;
    [SerializeField] private float magicHealingDelay = 0.3f;
    [SerializeField] private float magicHealingCooldown = 15f;
    private float magicHealingButtonTimmer = 0f;
    private float magicHealingCooldownTimmer = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        // Automatically find the stats script on the same object
        playerStats = GetComponent<PlayerStatsController>();

        // Good practice: check if it actually found it
        if (playerStats == null)
        {
            Debug.LogError("CombatController couldn't find PlayerStatsController on " + gameObject.name);
        }
    }

    void Update()
    {
        if (magicAttackCooldownTimmer > 0) magicAttackCooldownTimmer -= Time.deltaTime;
        if (magicHealingCooldownTimmer > 0) magicHealingCooldownTimmer -= Time.deltaTime;
        // 1. Normal Attack (Free)
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            NormalAttack();
        }

        // 2. Magic Attack (Costs Fuel)
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            
            
                MagicAttack();
            
        }

        // 3. Heal (Costs Fuel)
        if (Input.GetKeyDown(KeyCode.H))
        {
            
            
                Debug.Log("Out of fuel to heal!");
            
        }
    }

    void NormalAttack()
    {
        Debug.Log("Swinging sword/wrench!");
        // Play animation/Instantiate hitbox here
    }

    void MagicAttack()
    {
        Debug.Log("Firing fuel-injected fireball!");
        // Play magic effect here
    }
}
