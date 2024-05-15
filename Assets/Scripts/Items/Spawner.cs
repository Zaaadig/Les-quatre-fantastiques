using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnInterval = 3f;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnObject();
            timer = 0f;
        }
    }

    void SpawnObject()
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }
}
