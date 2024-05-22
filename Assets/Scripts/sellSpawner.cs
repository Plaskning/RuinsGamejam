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
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        
        if (currentSellPoints < maxSellPoints && elapsedTime > spawnRate)
        {
            elapsedTime = 0;
            Instantiate(sellPointPrefab, new Vector3(0, Random.Range(spawnerTop,spawnerBottom), 0), Quaternion.identity);
            currentSellPoints++;
        }
    }
}
