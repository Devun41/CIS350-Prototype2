/*
 Devun Schneider
 Prototype 2
 Controls the spawning of the animal entities/gameObjects
 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabsToSpawn;

    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnZPos = 20;

    public HealthSystem healthSystem;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomPrefab();
        }
    }
    private void Start()
    {
        //get a reference to the health system script
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
        //InvokeRepeating("SpawnRandomPrefab",2,1.5f);
        StartCoroutine(SpawnRandomPrefabWithCoroutine());
    }
    IEnumerator SpawnRandomPrefabWithCoroutine()
    {
        yield return new WaitForSeconds(3f);
        while (!healthSystem.gameOver)
        {
            float randomDelay = Random.Range(0.8f, 3.0f);
            SpawnRandomPrefab();
            yield return new WaitForSeconds(randomDelay);
        }
    }
    void SpawnRandomPrefab()
    {
        //pick a random spawn point
        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnZPos);
        //generate spawn pos
        int prefabIndex = Random.Range(0, prefabsToSpawn.Length);
        //spawn
        Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);
    }

}
