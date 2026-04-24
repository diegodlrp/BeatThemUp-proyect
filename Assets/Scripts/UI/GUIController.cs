using UnityEngine;
using UnityEngine.UI;

public class GUIController : MonoBehaviour
{
    [SerializeField] Slider motorBikeSlider;
    [SerializeField] Slider fuelSlider;
    [SerializeField] Slider healthSlider;

    // Métodos para inicializar
    public void SetupUI(float maxMoto, float maxFuel, float maxHealth)
    {
        motorBikeSlider.maxValue = maxMoto;
        motorBikeSlider.value = maxMoto;

        fuelSlider.maxValue = maxFuel;
        fuelSlider.value = maxFuel;

        healthSlider.maxValue = maxHealth;
        healthSlider.value = maxHealth;
    }

    // Métodos de actualización
    public void UpdateMotoHealth(float value) => motorBikeSlider.value = value;
    public void UpdateFuel(float value) => fuelSlider.value = value;
    public void UpdatePlayerHealth(float value) => healthSlider.value = value;
}
