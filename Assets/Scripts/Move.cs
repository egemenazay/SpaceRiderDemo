using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Move : MonoBehaviour
    {
        [SerializeField] private int speed = -4;
        private void FixedUpdate()
        {
            transform.position += new Vector3(0,speed,0) * Time.deltaTime;
        }
        
    }
    
}