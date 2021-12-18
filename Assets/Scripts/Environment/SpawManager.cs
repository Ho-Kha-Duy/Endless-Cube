using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;

    private float spawnPosZ = 100f;
    private float startDelay = 4f;
    private float repeatRate = 2f;

    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("RandomObstacle", startDelay, repeatRate);
    }

    void RandomObstacle()
    {
        int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
        Vector3 spawnPos = new Vector3(0, 0, spawnPosZ);

        if(GameManager.instance.gameHasEnded == false)
        {
            Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, Quaternion.identity);
        }
    }
}
