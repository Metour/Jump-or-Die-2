using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2f;
    private float horizontal;
    private float vertical;
    public float jump = 2f;
    private Animator anim;
    
    public PlayableDirector director;

    //private Transform playerTransform;
    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        /*if(GroundChecker.isGrounded)
        {
            A
        }*/
    }

    // Start is called before the first frame update
    void Start()
    {
        //playerTransform = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if(horizontal == 0)
        {
            anim.SetBool("Correr", false);
        }

        else
        {
            anim.SetBool("Correr", true);
        }

        //Rotarpj

        vertical = Input.GetAxisRaw("Vertical");

        if(vertical == 1)
        {
            anim.SetBool("Saltar", true);
        }

        else
        {
            anim.SetBool("Saltar", false);
        }


        //playerTransform.position += new Vector3 (horizontal * speed * Time.deltaTime, 0, 0);
        //playerTransform.position += new Vector3 (1, 0, 0)* horizontal * speed * Time.deltaTime;
        //playerTransform.Translate(Vector3.right * horizontal * speed * Time.deltaTime, Space.World);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2 (2f, 0f)* horizontal * speed;
        
        //rb.AddForce(new Vector2 (100f, 0f) * horizontal * speed * Time.deltaTime); (Cosas puntuales, ejemplo: dash o salto, no para moverse)
        //rb.MovePosition(rb.position + new Vector2 (1f, 0f) * horizontal * speed * Time.deltaTime);
        //transform.position = Vector2.MoveTowards (transform.position, new Vector2 (8f, transform.position.y), horizontal * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Cinematica")
        {
            director.Play();
        }        
    }
}
