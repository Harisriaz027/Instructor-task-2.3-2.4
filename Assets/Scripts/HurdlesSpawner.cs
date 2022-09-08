using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurdlesSpawner : MonoBehaviour
{
    public GameObject[] hurdles;
    private float spawnPosY = 10.5f;
    private float spawnPosZ = 0;
    public GameObject Gem;
    void Start()
    {
        InvokeRepeating("SpawnHurdle", 2, 3);
        InvokeRepeating("HeartSpawner", 1, 3);
    }

    void SpawnHurdle()
    {
        int Index = Random.Range(0, hurdles.Length);
        hurdles[Index].gameObject.SetActive(false);
        for(int i = 0; i < 5; i++)
        {
            Vector3 spawn = new Vector3(hurdles[i].transform.position.x, spawnPosY, spawnPosZ);
            Instantiate(hurdles[i], spawn, hurdles[i].transform.rotation);
        }
         hurdles[Index].gameObject.SetActive(true);
    }
    void HeartSpawner()
    {
        Vector3 spawn = new Vector3(Random.Range(-6,6), spawnPosY, spawnPosZ);
        Instantiate(Gem, spawn, Gem.transform.rotation);
    }
}
