using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 20f;
    private PlayerController playerControllerScript;

    private float leftBound = -15f;

    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
