using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private int spawnRange = 9;
    private float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        // Ticker for per frame calculations
        SpawnTimerTick();

        // Instantiating spawns
        Spawn();

    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return spawnPos;
    }

    private void SpawnTimerTick()
    {
        // Increment spawnTimer by time deltaTime.
        spawnTimer += Time.deltaTime;


    }

    private void Spawn()
    {
        int spawnRate = Random.Range(5, 10);

        if (spawnTimer >= spawnRate)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
            spawnTimer = 0;
        }
    }
}
