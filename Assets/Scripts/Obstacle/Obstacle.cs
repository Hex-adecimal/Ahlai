using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;
    public GameObject eye;
    private float spawnTime;
    private float timeBetweenSpawn = 0.5f;
    private bool isOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        eye.SetActive(isOpen);

        if (Time.time > spawnTime)
        {
            isOpen = !isOpen;
            spawnTime = Time.time + timeBetweenSpawn;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Garbage collector
        if (collision.CompareTag("Border"))
        {
            Destroy(gameObject);
        }

        if (collision.CompareTag("Player") && isOpen)
        {
            Destroy(player.gameObject);
        }
    }
}
