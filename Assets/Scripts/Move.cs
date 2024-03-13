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
        
    }
    
}