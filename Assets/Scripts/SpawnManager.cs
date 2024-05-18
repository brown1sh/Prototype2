using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;

    private float spawnRangeZMin = -1f;
    private float spawnRangeZMax = 15f;
    private float spawnPosX = 30f;

    private float startDelay = 2f;
    private float spawnInterval = 0f;
    private float minDelay = 1f;
    private float maxDelay = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomAnimalVertical", startDelay); // upon start, begin calling the function SpawnRandom animal every 1.5 secs after initial delay

        Invoke("SpawnRandomAnimalHorizontal", startDelay);
    }

    void SpawnRandomAnimalVertical()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length); // which animal to spawn
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ); // random location to spawn

        spawnInterval = Random.Range(minDelay, maxDelay);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation); // spawn random animal at random spawn location

        Invoke("SpawnRandomAnimalVertical", spawnInterval);
    }

    void SpawnRandomAnimalHorizontal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length); // which animal to spawn
        

        float randomSideSpawn = Random.Range(0, 10);

        spawnInterval = Random.Range(minDelay, maxDelay);

        if (randomSideSpawn <= 4)
        {
            Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(spawnRangeZMin, spawnRangeZMax));
            Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, 270, 0)); // spawn random animal at random spawn location
            Debug.Log("Right side");
        }
        else
        {
            Vector3 spawnPos = new Vector3(-spawnPosX, 0, Random.Range(spawnRangeZMin, spawnRangeZMax));
            Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, 90, 0)); // spawn random animal at random spawn location
            Debug.Log("Left side");
        }

        Invoke("SpawnRandomAnimalHorizontal", spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
