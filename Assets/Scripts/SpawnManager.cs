using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class SpawnManager : MonoBehaviour
{
    private CharacterController controller;
    public GameObject[] boxPrefabs;
    private float spawnRangeX = 1;
    private float spawnPosZ = 0.25f;
    private bool spawned = false;

    public void onSpawned(InputAction.CallbackContext context)
    {
        spawned = context.action.triggered;
    }

    // Update is called once per frame
    void update()
    {
        if (spawned == true)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1, spawnPosZ);
            int boxIndex = Random.Range(0, boxPrefabs.Length);
            GameObject goInst = (GameObject) Instantiate (boxPrefabs[boxIndex], transform.position + spawnPos,
                boxPrefabs[boxIndex].transform.rotation);
            goInst.transform.parent = transform;
        }
    }
}
