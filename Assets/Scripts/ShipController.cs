using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class ShipController : MonoBehaviour
{
    private GameOver _gameOver;
    private Rigidbody2D rgb2d;
    float speed = 7f;
    bool pause = false;
    private float previousTimeScale;
    [SerializeField] public GameObject gameOverScreen;

    private void Awake()
    {
        rgb2d = GetComponent<Rigidbody2D>();
        gameOverScreen.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
        
    }

    void TogglePause()
    {
        if(Time.timeScale > 0)
        {
            previousTimeScale = Time.timeScale;
            Time.timeScale = 0;
            pause = true;
        }
        else if(Time.timeScale == 0)
        {
            Time.timeScale = previousTimeScale;
            pause = false;
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rgb2d.transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rgb2d.transform.position += new Vector3(speed,0,0) * Time.deltaTime;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("meteor"))
        {
            gameOverScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
