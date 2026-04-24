using UnityEngine;

public class PlayerOnFootController : MonoBehaviour, IMovement
{
    float currentSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float GetCurrentSpeed()
    {
        return this.currentSpeed;
    }

    public void SetEnabled(bool state)
    {
        this.enabled = state;
    }

    public float GetBaseSpeed()
    {
        return 0;
    }

    public bool IsAccelerating()
    {
        return false;
    }
}
