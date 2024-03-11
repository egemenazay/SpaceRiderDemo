using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Move : MonoBehaviour
    {
        private void FixedUpdate()
        {
            transform.position += new Vector3(0,-4,0) * Time.deltaTime;
        }
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                transform.position = new (0, 11.12f, 0);
            }
        }
    }
    
}