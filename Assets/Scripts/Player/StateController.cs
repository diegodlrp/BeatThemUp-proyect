using UnityEngine;

public class StateController : MonoBehaviour
{
    private PlayerOnMotorbikeController motorbikeObject; 
    private PlayerOnFootController footObject;

    private PlayerStatsController statsController;

    private IMovement onMotorbikeController;
    private IMovement onFootController;

    void Awake()
    {
        motorbikeObject = GetComponent<PlayerOnMotorbikeController>();
        footObject = GetComponent<PlayerOnFootController>();
        statsController = GetComponent<PlayerStatsController>();

        onMotorbikeController = motorbikeObject as IMovement;
        onFootController = footObject as IMovement;

        if (motorbikeObject == null || footObject == null || statsController == null)
        {
            Debug.LogError("StateController: Missing required scripts on " + gameObject.name);
        }
    }
   
    void Start()
    {
        SwitchToBike();
    }

    public void SwitchToBike()
    {
        onFootController.SetEnabled(false);
        onMotorbikeController.SetEnabled(true);
        statsController.SetActiveMovement(onMotorbikeController);
    }

    public void SwitchToFoot()
    {
        onFootController.SetEnabled(true);
        onMotorbikeController.SetEnabled(false);
        statsController.SetActiveMovement(onFootController);
    }
}
