using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Vector3 initialPosition = new Vector3(0, 0, 0);

    public float rotationSpeedX = 300.0f;
    public float rotationSpeedY = 300.0f;
    public float rotationSpeedZ = 300.0f;

    public Vector3 initialScale = new Vector3(1, 1, 1);

    public float scaleEpsilon = 0.5f;

    public float colorChangeInterval = 0.5f;
    public float scaleChangeInterval = 0.5f;
    
    void Start()
    {
        transform.position = initialPosition;
        transform.localScale = initialScale;
        InvokeRepeating("ChangeColorRandomly", 0.0f, colorChangeInterval);
        InvokeRepeating("ChangeScaleRandomly", 0.0f, scaleChangeInterval);
    }
    
    void Update()
    {
        transform.Rotate(rotationSpeedX * Time.deltaTime, rotationSpeedY * Time.deltaTime, 0.0f);
    }

    void ChangeColorRandomly()
    {
        Material material = Renderer.material;
        material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }

    void ChangeScaleRandomly()
    {
        float scaleFactor = 1.0f + Random.Range(-scaleEpsilon, scaleEpsilon);
        transform.localScale = initialScale * scaleFactor;
    }
}
