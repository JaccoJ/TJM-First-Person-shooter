using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public bool isGrounded;
    private Rigidbody rb;
    public float jumpHeight;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "floor")
        {
            isGrounded = true;
        }
    }

    void Update()
    {
        if (isGrounded && Input.GetKeyDown("space"))
        {
            rb.velocity = new Vector3(0, 10 * jumpHeight * Time.deltaTime, 10);
            isGrounded = false;
        }


    }
}