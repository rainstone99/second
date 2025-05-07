using Unity.Mathematics;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnRate = 1f;
    public GameObject WallPrefab;

    float nextTimeToSpawn = 0f;


    void Update()
    {
        if (Time.time >= nextTimeToSpawn)
        {
            Instantiate(WallPrefab, Vector3.zero, quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }        
    }
}
