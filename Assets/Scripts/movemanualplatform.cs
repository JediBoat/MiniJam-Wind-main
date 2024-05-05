using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemanualplatform : MonoBehaviour
{
 private float speedy;
 public buttonpress script;
    [SerializeField]private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        moving();
    }
    

    private void moving()
    {
       rb.velocity = new Vector2(0,rb.velocity.y + speedy);

       if (script.buttonpressed  == true)
        {
            speedy = 0.05f;
            print("yes");
            script.buttonpressed  = false;
        }
    }

    


     private void OnTriggerEnter2D(Collider2D collider)
    {
        
        if (collider.gameObject.CompareTag("check1"))
        {
            rb.velocity = new Vector2(0,0);
            speedy = 0.05f;
            
        }
        else if(collider.gameObject.CompareTag("check2")){
            rb.velocity = new Vector2(0,0);
            speedy = -0.05f;
        }
        
    }

    
}
