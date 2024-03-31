using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mckeygrab : MonoBehaviour
{

    public bool keygrabbed = false;
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        
        if (collider.gameObject.CompareTag("key"))
        {
            keygrabbed = true;
            
        }
        
    }
}
