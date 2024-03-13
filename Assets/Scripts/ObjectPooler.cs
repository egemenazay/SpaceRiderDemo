
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    
    
    
    [SerializeField] public GameObject objPrefab;
    [SerializeField] public int poolSize;

    private Queue<GameObject> pooledObjects;

    private void Awake()
    {
        pooledObjects = new Queue<GameObject>();

        for (int i = 0; i < poolSize ;i++)
        {
            GameObject obj = Instantiate(objPrefab);
            obj.SetActive(false);
            pooledObjects.Enqueue(obj);
        }
    }

    public GameObject GetPooledObject()
    {
        GameObject obj = pooledObjects.Dequeue();
        obj.SetActive(true);
        pooledObjects.Enqueue(obj);
        return obj;
    }
}
