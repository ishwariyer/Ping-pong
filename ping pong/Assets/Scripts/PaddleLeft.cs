using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleLeft : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public bool isPlayer1;
   
    // Update is called once per frame
    private void Update()
    {
        if (isPlayer1)
        {
            movement.y = Input.GetAxis("Vertical");
        }
        
        
    }
    private void FixedUpdate()
    {
        if (isPlayer1)
        {
            rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        }
        
    }
}
