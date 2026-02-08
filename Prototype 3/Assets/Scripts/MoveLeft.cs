using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 20f;
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
