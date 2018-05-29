using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody2D rigidBody;
    public SpriteRenderer sr;
    public float thrust = 10.0f;
    public bool isJumping = false;
    public float horizontalThrust = 40.0f;
    public float verticalThrust = 400.0f;
    public float baseY = 0.05f;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }
	void FixedUpdate ()
    {
        Vector2 movingVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        rigidBody.AddForce(transform.right * movingVector.x * horizontalThrust);

        var localVelocity = transform.InverseTransformDirection(rigidBody.velocity);
        if(localVelocity.x < 0)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }


        if (Input.GetKeyDown("space"))
        {
            if(transform.position.y < baseY)
            {
                rigidBody.AddForce(transform.up * verticalThrust);
            }

        }

        if (rigidBody.velocity.magnitude > horizontalThrust)
        {
            rigidBody.velocity = rigidBody.velocity.normalized * horizontalThrust;
        }

    }
}
//rigidBody.velocity = transform.right * movingVector.x * 40.0f;