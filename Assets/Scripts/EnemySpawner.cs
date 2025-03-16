using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    [Header("Wave settings")]
    public int count = 10;
    public Transform spawnPoint;
    public float cooldown = 1;
    [Header("Spawn settings")]
    public int waveCount = 10;
    public float waveCooldown = 2;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        for (int i = 0; i < waveCount; i++)
        {
            for (int j = 0; j < count; j++)
            {
                        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
                        yield return new WaitForSeconds(cooldown);
            }
            yield return new WaitForSeconds(waveCooldown);
        }
        
        
        
    }
}
