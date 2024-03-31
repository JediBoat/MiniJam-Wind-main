using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
   [SerializeField] private inputcontrol input = null;

   [SerializeField]private Transform checkpoint;
   [SerializeField]private Transform Player;
   

     private void OnTriggerEnter2D(Collider2D collider)
    {
        
        if (input.retrievinteractinput() && collider.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject, 3);
            
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Player.position = checkpoint.position;
    }
}
