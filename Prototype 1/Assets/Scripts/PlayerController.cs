using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f; 
    void Start()
    {

    }

    void Update()
    {
        // Move the vehicle forward
        // transform.Translate(0,0,1);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
