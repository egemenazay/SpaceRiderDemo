using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] public GameObject gameOverScreen;
    public void Setup()
    {
        gameOverScreen.SetActive(true);
    }
    public void GameOverFalse()
    {
        gameOverScreen.SetActive(false);
    }
}
