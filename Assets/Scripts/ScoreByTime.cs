using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ScoreByTime : MonoBehaviour
{
    public TMP_Text scoreText1;
    public TMP_Text scoreText2;
    private float _scoreAmount;
    [SerializeField] private float pointIncreasedPerSecond;
  
    private void Start()
    {
        _scoreAmount = 0;
    }

    private void Update()
    {
        scoreText1.text = ""+(int)_scoreAmount;
        scoreText2.text = ""+(int)_scoreAmount;
        _scoreAmount +=  pointIncreasedPerSecond * Time.deltaTime;
    }
}
