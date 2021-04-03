using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemy;
    public GameObject powerup;

    public float spawnRange = 9;
    public int waveCount = 1;
    public int enemyCount;
  

    void Start()
    {

    }

    void Update()
    {
        enemyCount = FindObjectsOfType<EnemyController>().Length;

        if (enemyCount == 0) {
            waveCount++;
            SpawnEnemyWave(waveCount);
            SpawnPowerupWave();
        }
    }

    void SpawnPowerupWave()
    {
        Instantiate(powerup, GenerateSpawnPosition(), powerup.transform.rotation);
    }

    void SpawnEnemyWave(int waveCount)
    {
        for (int i = 0; i < waveCount; i++)
        {
            SpawnEnemy(GenerateSpawnPosition());
        }

    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        return new Vector3(spawnPosX, 0, spawnPosZ);
    }

    void SpawnEnemy(Vector3 spawnPos)
    {
        Instantiate(enemy, spawnPos, enemy.transform.rotation);
    }
}
