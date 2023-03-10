using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = -9;

    public int enemyCount;
    public int waveNumber = 1;

    public GameObject powerupPrefab;

    // Start is called before the first frame update
    void Start()
    {
        spawnEnemyWave(waveNumber);
        Instantiate(powerupPrefab, generateSpawnPos(), powerupPrefab.transform.rotation);
    }

    private Vector3 generateSpawnPos() {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }

    void spawnEnemyWave(int enemiesToSpawn) {
        for (int i = 0; i < enemiesToSpawn; i++) {
            Instantiate(enemyPrefab, generateSpawnPos(), enemyPrefab.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0) {
            waveNumber++;
            Instantiate(powerupPrefab, generateSpawnPos(), powerupPrefab.transform.rotation);
            spawnEnemyWave(waveNumber);
        }
    }
}
