using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Vector2 jump;
    public float jumpForce = 2.0f;

    public bool isGrounded;
    Rigidbody2D rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        jump = new Vector2(0.0f, 6.0f);
	}

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
        Debug.Log("Leaving 2d " + collision.gameObject.tag);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
        Debug.Log("Hit the 2d " + collision.gameObject.tag);
    }

    // Update is called once per frame
    void Update () {
		if(Input.GetKeyDown("space") && isGrounded)
        {
            rb.AddForce(jump, ForceMode2D.Impulse);

        }
	}
}
