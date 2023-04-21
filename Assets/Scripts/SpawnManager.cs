using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] boxPrefabs;
    private float spawnRangeX = 1;
    private float spawnPosZ = 0.25f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1, spawnPosZ);
            int boxIndex = Random.Range(0, boxPrefabs.Length);
            GameObject goInst = (GameObject) Instantiate (boxPrefabs[boxIndex], transform.position + spawnPos,
                boxPrefabs[boxIndex].transform.rotation);
            goInst.transform.parent = transform;
        }
    }
}
