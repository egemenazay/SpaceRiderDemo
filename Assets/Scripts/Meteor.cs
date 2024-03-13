using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Meteor : MonoBehaviour
{
    [SerializeField] private float spawnRate = 1;
    [SerializeField] private ObjectPooler objectPool = null;


    private void Start()
    {
        StartCoroutine(nameof(SpawnRoutine));
    }

    private IEnumerator SpawnRoutine()
    {
        while (true)
        {
            GameObject obj = objectPool.GetPooledObject();
            obj.transform.position = new Vector2(Random.Range(2f, -2f), 8f);
            yield return new WaitForSeconds(spawnRate);
        }
    }
}
