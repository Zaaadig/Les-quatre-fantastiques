using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn; // The object you want to spawn
    public float spawnInterval = 3f; // Interval between spawns in seconds
    private float timer = 0f; // Timer to track time between spawns

    void Update()
    {
        // Increment the timer
        timer += Time.deltaTime;

        // If the timer exceeds the spawn interval, spawn the object and reset the timer
        if (timer >= spawnInterval)
        {
            SpawnObject();
            timer = 0f;
        }
    }

    void SpawnObject()
    {
        // Spawn the object at the spawner's position and rotation
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }
}
