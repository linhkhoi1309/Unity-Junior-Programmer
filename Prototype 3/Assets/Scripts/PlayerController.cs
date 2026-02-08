using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody playerRb;
    public float jumpForce = 10f;
    public float gravityModifier;

    public bool isOnGround = true;
    public bool gameOver = false;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            // playerRb.AddForce(Vector3.up * 10, ForceMode.Acceleration);
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        } else if(other.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
        }
    }
}
