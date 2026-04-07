using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerOnMotorbikeController : MonoBehaviour
{
    [SerializeField] float baseSpeed = 2;
    [SerializeField] float maxSpeed = 10;
    [SerializeField] float verticalSpeed = 5f;

    [SerializeField] float accelerationRate = 8f;
    [SerializeField] float decelerationRate = 4f;

    [SerializeField] float minY = -3f;
    [SerializeField] float maxY = 3f;

    float currentSpeed;
    bool playerAcelerating;
    float direction;

    public InputActionReference move;
    public InputActionReference accelerate;

    void Start()
    {
        currentSpeed = baseSpeed;
    }

    void OnEnable()
    {
        move.action.Enable();
        accelerate.action.Enable();
    }

    void OnDisable()
    {
        move.action.Disable();
        accelerate.action.Disable();
    }

    void Update()
    {
        // INPUT
        direction = move.action.ReadValue<float>();
        playerAcelerating = accelerate.action.IsPressed();

        // ACCELERATION
        float targetSpeed = playerAcelerating ? maxSpeed : baseSpeed;
        float rate = playerAcelerating ? accelerationRate : decelerationRate;

        currentSpeed = Mathf.MoveTowards(currentSpeed, targetSpeed, rate * Time.deltaTime);

        // MOVEMENT
        Vector3 movement = new Vector3(
            currentSpeed * Time.deltaTime,
            direction * verticalSpeed * Time.deltaTime,
            0
        );

        transform.Translate(movement);

        // CLAMP POSITION
        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        transform.position = pos;
    }
}