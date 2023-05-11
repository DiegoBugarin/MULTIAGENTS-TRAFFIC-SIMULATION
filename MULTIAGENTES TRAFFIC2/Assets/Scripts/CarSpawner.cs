using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [Header("Delay between spawns")]
    public float spawnDelay;
    public GameObject[] spawnPrefabs;

    //CarPooler carPooler1;

    private void Start()
    {
        //carPooler1 = CarPooler.instance;
        InvokeRepeating("spawnCar", 0.0f, spawnDelay);
    }

    private void spawnCar()
    {
        int prefabI = Random.Range(0, spawnPrefabs.Length);
        //carPooler1.SpawnFromPool("CarH1", transform.position, Quaternion.identity);
        Instantiate(spawnPrefabs[prefabI], transform.position, spawnPrefabs[prefabI].transform.rotation);
    }
}
