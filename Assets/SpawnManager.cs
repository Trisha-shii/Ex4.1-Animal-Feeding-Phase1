using UnityEngine;

public class SpawnManager : MonoBehaviour
{

public GameObject[] animalPrefabs;
private float spawnRangeX = 10;
private float spawnPosZ = 5; //Dist from the player
private float startDelay = 2;
private float spawnInterval = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        // Generate a random index based on the number of animal prefabs
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // Generate a random spawn position within the defined range
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        // Instantiate the selected animal prefab at the generated position with no rotation
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
