using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] zodiacPrefabs;
    public float sideSpawnMinZ;
    public float sideSpawnMaxZ;
    public float sideSpawnX;
    private float sideBound = 100;
    private float startDelay = 1;
    private float spawnInterval = 1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomZodiac", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > sideBound)
        {
            Destroy(gameObject);
        }

        else if (transform.position.x < -sideBound)
        {
            Destroy(gameObject);
        }
    }

    void SpawnRandomZodiac()
    {
        void SpawnLeftZodiac()
        {
            int zodiacIndex = Random.Range(0, zodiacPrefabs.Length);
            Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
            Instantiate(zodiacPrefabs[zodiacIndex], spawnPos, zodiacPrefabs[zodiacIndex].transform.rotation);
        }

        void SpawnRightZodiac()
        {
            int zodiacIndex = Random.Range(0, zodiacPrefabs.Length);
            Vector3 spawnPos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
            Instantiate(zodiacPrefabs[zodiacIndex], spawnPos, zodiacPrefabs[zodiacIndex].transform.rotation);
        }
    }
}
