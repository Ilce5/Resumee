using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;
    Vector4 whereToSpawn;
    public float spawnRate = 5f;
    float nextSpawn = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            Vector3 position = new Vector3(Random.Range(-2.4F, 2.4F), Random.Range(-4.4F, 4.4F), 0);
            Instantiate(coin, position, Quaternion.identity);
        }
    }
}
