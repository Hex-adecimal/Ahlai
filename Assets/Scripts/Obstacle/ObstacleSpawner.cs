using UnityEngine;

public class ObstaclesSpawner : MonoBehaviour
{
    public GameObject obstacle;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float timeBetweenSpawn;
    private float spawnTime;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float X = Random.Range(minX, maxX);
        float Y = Random.Range(minY, maxY);

        Instantiate(obstacle, transform.position + new Vector3(X, Y, 0), transform.rotation);
    }
}
