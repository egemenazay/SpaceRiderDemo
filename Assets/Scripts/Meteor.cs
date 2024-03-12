using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour, IPooledObjects
{
    
    public void OnObjectSpawn()
    {
        transform.position = new Vector2(Random.Range(2f, -2f),8f);
    }
}
