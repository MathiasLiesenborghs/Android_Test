using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathiasSpawner : MonoBehaviour
{
    public GameObject objectPrefab; 
    public float spawnRateMin = 1f; 
    public float spawnRateMax = 3f; 
    public float objectSpeed = 2f; 
    public float spawnHeight = 10f; 


    private void Start()
    {
        
        StartCoroutine(SpawnObjects());
    }

    
    private IEnumerator SpawnObjects()
    {
        while (true)
        {
           
            yield return new WaitForSeconds(Random.Range(spawnRateMin, spawnRateMax));

            
            SpawnObject();
        }
    }

    private void SpawnObject()
    {
        
        float randomX = Random.Range(-Screen.width / 2f, Screen.width / 2f);
        Vector3 spawnPosition = new Vector3(randomX, spawnHeight, 0f);

        
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(spawnPosition);
        worldPos.z = 0f; 

        
        GameObject spawnedObject = Instantiate(objectPrefab, worldPos, Quaternion.identity);

        
        StartCoroutine(MoveObjectDown(spawnedObject));
    }

    
    private IEnumerator MoveObjectDown(GameObject obj)
    {
        
        Vector3 startPosition = obj.transform.position;

        
        float endY = -Screen.height / 2f;

        
        while (obj.transform.position.y > endY)
        {
            
            obj.transform.position += Vector3.down * objectSpeed * Time.deltaTime;
            yield return null; 
        }

        
        Destroy(obj);
    }
}
