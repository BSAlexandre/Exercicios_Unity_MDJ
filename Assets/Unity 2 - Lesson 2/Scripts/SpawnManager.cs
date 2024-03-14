using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    public float delay = 2;
    public float spawnInt = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRadom", delay, spawnInt);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRadom();
        }
    }

    void SpawnRadom()
    {
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnpos, animalPrefabs[animalIndex].transform.rotation);
    }
}
