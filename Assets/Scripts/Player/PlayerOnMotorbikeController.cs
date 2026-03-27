using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerOnMotorbikeController : MonoBehaviour
{
    [SerializeField] float baseSpeed = 2;
    [SerializeField] float maxSpeed = 10;
    float currentSpeed;
    bool playerAcelerating;

    public InputActionReference move;
    public InputActionReference accelerate;
    private float direction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentSpeed = baseSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        direction = move.action.ReadValue<float>();
        playerAcelerating = accelerate.action.IsPressed();
        this.transform.Translate(new Vector2(1 * currentSpeed * Time.deltaTime , direction * maxSpeed * Time.deltaTime));
    }

    private void FixedUpdate()
    {
        Debug.Log("DIRECTION"+ direction);
        Debug.Log("accelerate"+ playerAcelerating);
    }
}
