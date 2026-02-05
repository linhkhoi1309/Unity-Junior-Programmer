using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20.0f;
    private float spawnPosZ = 20.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ), animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
