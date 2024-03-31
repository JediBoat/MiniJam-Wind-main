using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bushscript : MonoBehaviour
{
    public AudioSource touchbush;
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        
        if (collider.gameObject.CompareTag("Player"))
        {   
            
            touchbush.Play();
            
        }
        
    }
}
