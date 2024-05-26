using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonpress : MonoBehaviour
{
    public bool buttonpressed = false;
    public Animator animator;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("boulder"))
        {
           animator.SetBool("button_press", true);
           buttonpressed  = true;
        }
    }

    
}
