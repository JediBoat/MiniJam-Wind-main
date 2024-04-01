using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
   [SerializeField] private inputcontrol input = null;

   [SerializeField]private Transform checkpoint;
   [SerializeField]private Transform Player;
   
   public AudioSource fireclip;
   public AudioSource fireclip2;

     private void OnTriggerEnter2D(Collider2D collider)
    {
        
        if (collider.gameObject.CompareTag("Player"))
        {
            fireclip.Play();
            
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Player.position = checkpoint.position;
        fireclip2.Play();
    }
}
