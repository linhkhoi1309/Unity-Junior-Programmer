using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public float cooldownTime = 2.0f;

    bool isCooldownActive = false;

    void ResetCooldownTime()
    {
       isCooldownActive = false;
    }
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && !isCooldownActive)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            isCooldownActive = true;
            Invoke("ResetCooldownTime", cooldownTime);
        }
    }
}
