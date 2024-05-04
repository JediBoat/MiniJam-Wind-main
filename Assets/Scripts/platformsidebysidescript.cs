using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class platformsidebysidescript : MonoBehaviour
{
   private float speedx;
    [SerializeField]private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        speedx = -0.05f;
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
}
