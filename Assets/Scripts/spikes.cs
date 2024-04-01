using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikes : MonoBehaviour
{
    private float count = 0;
    [SerializeField]private Transform checkpoint;
    [SerializeField]private Transform Player;

    public AudioSource spikedeathaudio;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        
        if (collider.gameObject.CompareTag("Player"))
        {   
            Player.position = checkpoint.position;
            spikedeathaudio.Play();
            
        }
        
    }
}
