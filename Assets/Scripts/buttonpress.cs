using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   private float speedx;
    [SerializeField]private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        speedx = -0f;
    }

    void Update()
    {
        moving();
    }
    

    private void moving()
    {
       rb.velocity = new Vector2(rb.velocity.x + speedx,0);
    }

     private void OnTriggerEnter2D(Collider2D collider)
    {
        
        if (collider.gameObject.CompareTag("check1"))
        {
            rb.velocity = new Vector2(0,0);
            speedx = 0.05f;
            
        }
        else if(collider.gameObject.CompareTag("check2")){
            rb.velocity = new Vector2(0,0);
            speedx = -0.05f;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {   
            speedx = -0.05f;
        }
    }

    
}
