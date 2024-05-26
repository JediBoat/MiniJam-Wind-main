using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propellermov : MonoBehaviour
{
    bool playercol;
    [SerializeField] private inputcontrol input = null;
    [SerializeField, Range(0f, 100f)] private float maxspeed = 4f;
    [SerializeField, Range(0f, 100f)] private float maxacceleration = 35f;
    [SerializeField, Range(0f, 100f)] private float maxairacceleration = 20f;
    private Vector2 direction;
    private Vector2 desiredvelocity;
    private Vector2 velocity;
    private Rigidbody2D body;
    private ground gr;
    BoxCollider2D boxCollider;
    private float maxspeedchange;
    private float acceleration;
    public Animator animator;
    SpriteRenderer m_SpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        playercol = false;
        boxCollider = GetComponent<BoxCollider2D>();
        //Fetch the SpriteRenderer from the GameObject
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        gr = GetComponent<ground>();
        velocity.y = 0;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           playercol=true;
        }
        else
        {
            playercol = false;  
        }
    }
    // Update is called once per frame
    void Update()
    {


       
        if (input.retrievewindability() && playercol)
        {
            velocity = body.velocity;
            velocity.y++ ;
            animator.SetBool("e_press", true);

            body.velocity = velocity;
            body.gravityScale = 1f;
        }
        else
        {
            if (velocity.y==0f)
            {
                animator.SetBool("e_press", false);
            }
            else
            {
                velocity.y--;
                animator.SetBool("e_press", false);
            }
            body.gravityScale = 9.1f;
            body.velocity = velocity;
        }
    }
    private void FixedUpdate()
    {

        


    }
}
