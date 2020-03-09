using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{

    public float speed = 500;
    public float jump = 400;

    private Rigidbody2D rb;
    private bool isGrounded;
    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody2D>();
        isGrounded = false;
        
    }

    // Update is called once per frame
    void Update(){
        float xDisplacement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        rb.velocity = new Vector2(xDisplacement, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.W)&& isGrounded){
            rb.AddForce(new Vector2(0, jump));
            isGrounded = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }
}
