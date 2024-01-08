using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class NeckSpawner : MonoBehaviour
{
    [SerializeField] GameObject neckPrefab;
    //[SerializeField] Transform[] neckPos;

    void Start()
    {

        //Spawn();
        StartCoroutine(SpawnRoutine());
    }

    void Update()
    {
        
    }

    private void Spawn()
    {
        List<Vector3> childPos = new List<Vector3>();

        foreach(Transform child in transform) { childPos.Add(child.position); }

        int rd = Random.RandomRange(0, childPos.Count);
        Vector3 spawnPos = childPos[rd];

        Instantiate(neckPrefab, spawnPos, Quaternion.identity);

        //StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            Spawn();
            yield return new WaitForSeconds(2);
        }
    }
}
