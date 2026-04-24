using UnityEngine;

public interface IMovement 
{
    float GetCurrentSpeed();
    float GetBaseSpeed();
    bool IsAccelerating();
    void SetEnabled(bool state);
    

}
