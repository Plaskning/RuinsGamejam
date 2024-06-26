using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sellSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] sellPointPrefab;


    [SerializeField] private float spawnerTop;

    [SerializeField] private float spawnerBottom;

    
    [SerializeField] float spawnRate;
    [SerializeField] int minRespawnTime;
    [SerializeField] int maxRespawnTime;
    [SerializeField] int additionalBadRolls;
    
    public float elapsedTime = 0.0f;

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > spawnRate)
        {
            elapsedTime = 0;
            int var = Random.Range(0, sellPointPrefab.Length + additionalBadRolls);
            if (var > 0)
                var = 1;
            spawnRate = Random.Range(minRespawnTime, maxRespawnTime);
            Instantiate(sellPointPrefab[var], new Vector3(transform.position.x, transform.position.y + Random.Range(spawnerTop,spawnerBottom), transform.position.z), Quaternion.identity);
        }
    }
}
