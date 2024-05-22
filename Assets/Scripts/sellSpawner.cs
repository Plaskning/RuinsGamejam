using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sellSpawner : MonoBehaviour
{
    [SerializeField] private GameObject sellPointPrefab;

    [SerializeField] private int maxSellPoints = 0;

    [SerializeField] private float spawnerTop;

    [SerializeField] private float spawnerBottom;

    public int currentSellPoints = 0;
    
    [SerializeField] float spawnRate;
    
    public float elapsedTime = 0.0f;

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > spawnRate)
        {
            elapsedTime = 0;
            if (currentSellPoints < maxSellPoints)
            {
                Instantiate(sellPointPrefab, new Vector3(transform.position.x, transform.position.y + Random.Range(spawnerTop,spawnerBottom), transform.position.z), Quaternion.identity);
                currentSellPoints++;
            }
        }
    }
}
