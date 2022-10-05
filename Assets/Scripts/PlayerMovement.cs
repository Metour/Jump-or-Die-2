using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.5f;
    private float horizontal;
    //private Transform playerTransform;
    private Rigidbody2D rb ;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
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
}
