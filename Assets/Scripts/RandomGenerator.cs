using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour
{
    float MaxTime = 1;
    float currentTime = 1;
    public GameObject rock;
    float randomNum;
    private void Update()
    {
        randomNum = Random.Range(2f, -2f);
        currentTime += Time.deltaTime;
        if (currentTime >= MaxTime)
        {
            currentTime = 0;
            Instantiate(rock, new Vector2(randomNum, 8), Quaternion.identity);
        }
    }
}
