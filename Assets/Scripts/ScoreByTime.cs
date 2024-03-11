using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ScoreByTime : MonoBehaviour
{
    public TMP_Text scoreText;
    public float scoreAmount;
    public float pointIncreasedPerSecond;
  
    private void Start()
    {
        scoreAmount = 0;
        pointIncreasedPerSecond = 1f;
    }

    private void Update()
    {
        scoreText.text = ""+(int)scoreAmount;
        scoreAmount +=  pointIncreasedPerSecond * Time.deltaTime;
    }
}
