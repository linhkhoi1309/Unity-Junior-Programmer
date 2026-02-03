using UnityEngine;

public class RotatePropellerX : MonoBehaviour
{
    public float rotationSpeed = 500f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
