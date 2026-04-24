using UnityEngine;

public class PlayerStatsController : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float maxMotorBikeHealth = 100f;
    [SerializeField] private float maxFuel = 50f;
    [SerializeField] private float maxHealth = 20f;

    [Header("References")]
    [SerializeField] private GUIController gui;

    private IMovement activeMovement;

    private float motorBikeHealth;
    private float fuel;
    private float health;

    void Start()
    {
        motorBikeHealth = maxMotorBikeHealth;
        fuel = maxFuel;
        health = maxHealth;

        if(gui != null)
        {
            gui.SetupUI(maxMotorBikeHealth, maxFuel, maxHealth);
        }   
    }

    void Update()
    {
        ConsumeFuel();
    }

    private void ConsumeFuel()
    {
        if (activeMovement is PlayerOnMotorbikeController && fuel > 0)
        {
            float speed = activeMovement.GetCurrentSpeed();
            // Fuel consumption formula: (Base Rate + Speed Modifier) * Time
            float consumption = (1.0f + (speed * 0.5f)) * Time.deltaTime;
            fuel -= consumption;

            gui.UpdateFuel(fuel);

            if (fuel <= 0)
            {
                fuel = 0;
                // Trigger logic to force player off bike?
            }
        }
    }

    public void SetActiveMovement(IMovement activeMovement)
    {
        this.activeMovement = activeMovement;
        Debug.Log("activeMovement" + activeMovement);
    }

    public void ApplyDamage(float damage)
    {
        if (motorBikeHealth > 0)
        {
            motorBikeHealth -= damage;
            motorBikeHealth = Mathf.Max(motorBikeHealth, 0); // Evita valores negativos
            gui.UpdateMotoHealth(motorBikeHealth);
            Debug.Log("Moto tomó daño. Restante: " + motorBikeHealth);
        }
        else
        {
            health -= damage;
            health = Mathf.Max(health, 0);
            gui.UpdatePlayerHealth(health);
            Debug.Log("Jugador tomó daño. Restante: " + health);
        }
    }

    public void HandleCollision(string type)
    {
        bool isOnBike = activeMovement is PlayerOnMotorbikeController;
        float speed = activeMovement.GetCurrentSpeed();

        switch (type)
        {
            case "Crack":
                Debug.Log("ajiojfoilajfklasdf" + speed);
                if (isOnBike)
                {
                    // Cracks hurt more the faster you go
                    ApplyDamage(speed * 5f);
                }
                break;

            case "Barricade":
                // Barricades hurt if you don't have enough momentum to break through
                if (speed < 5f)
                {
                    ApplyDamage(20f);
                }
                break;
        }
    }
}
