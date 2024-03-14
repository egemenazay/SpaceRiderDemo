using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    [SerializeField] public GameObject gameOverScreen;
    
    public void RestartLevel()
    {
        gameOverScreen.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene("Scenes/Game");
    }
    
    public void StartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Scenes/Game");
    }
    
    public void BackMenu()
    {
        SceneManager.LoadScene("Scenes/TitleScreen");
    }
}
