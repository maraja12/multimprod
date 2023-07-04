using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    float jumpForce;
    bool gameOver = false;
    bool grounded;

    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetMouseButtonDown(0) && !gameOver) {
        if(grounded){
            Jump();
        }
     }  
    }

    void Jump(){

        grounded = false;
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Ground"){
            grounded = true;
        }
    }
}
