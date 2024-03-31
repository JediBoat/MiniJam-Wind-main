using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mckeygrab : MonoBehaviour
{

    public bool keygrabbed = false;
    public Animator animator;
    public AudioSource keypickup_1;
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        
        if (collider.gameObject.CompareTag("key"))
        {   
            animator.SetBool("keygot", true);
            keygrabbed = true;
            keypickup_1.Play();
            
        }
        
    }
}
