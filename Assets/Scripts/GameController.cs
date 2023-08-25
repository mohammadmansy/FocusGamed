using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameController : MonoBehaviour
{
    public GameObject circlePrefab;
    public float spawnInterval = 2f; // Time between circle spawns

    private float timeSinceLastSpawn = 0f;

    private void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnCircle();
            timeSinceLastSpawn = 0f;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }

    private void SpawnCircle()
    {
        // Create a new circle and position it randomly on the screen
        GameObject circle = Instantiate(circlePrefab, GetRandomPosition(), Quaternion.identity);
        // Attach the CircleController script to the new circle
        circle.AddComponent<CircleController>();
    }

    private Vector3 GetRandomPosition()
    {
        float x = Random.Range(-1.87f, 1.87f); // Adjust these values to fit your screen
        float y = Random.Range(-4.5f, 4.1f); // Adjust these values to fit your screen
        return new Vector3(x, y, 0f);
    }
}