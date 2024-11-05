using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathiasSpawner : MonoBehaviour
{
    public GameObject objectPrefab;
    public float spawnRateMin = 1f;
    public float spawnRateMax = 1f;
    public float objectSpeed = 2f;
    public float spawnHeight = 10f;

    private float timeToNextSpawn = 0f;

    void Start()
    {
        timeToNextSpawn = Random.Range(spawnRateMin, spawnRateMax);
    }

     void Update()
    {
        timeToNextSpawn -= Time.deltaTime;

        if (timeToNextSpawn < 0f)
        {
            timeToNextSpawn = Random.Range(spawnRateMin, spawnRateMax);
        }
    }

    void SpawnObject()
    {
        //setting to spawn object on x axis

        float randomX = Random.Range(-Screen.width / 2f, Screen.width / 2f);
        Vector3 spawnPosition = new Vector3(randomX, spawnHeight, 0f);

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(spawnPosition);
        worldPos.z = 0f;

        GameObject spawnedObject = Instantiate(objectPrefab, worldPos, Quaternion.identity);


    }
}
