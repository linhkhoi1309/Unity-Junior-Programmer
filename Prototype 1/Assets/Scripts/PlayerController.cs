using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f; 
    private float turnSpeed = 45.0f; 
    private float horizontalInput;
    private float forwardInput;
    void Start()
    {

    }

    void Update()
    {
        // Moves the car forward based on vertical input
        // transform.Translate(0,0,1);
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Slide the vehicle left and right
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
