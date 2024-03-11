using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RockDeleter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("meteor"))
        {
            Destroy(collision.gameObject);
            Debug.Log("Meteor Detected");
        }
        if (collision.gameObject.CompareTag("space"))
        {
            
            Debug.Log("Space Detected");
        }
    }
}
