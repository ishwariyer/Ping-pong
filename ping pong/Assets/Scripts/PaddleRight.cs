using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleRight : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    [SerializeField] public bool isPlayer2;
    void Update()
    {
        if (isPlayer2)
        {
            movement.y = Input.GetAxis("Vertical1");
        }
        
    }
    private void FixedUpdate()
    {
        if(isPlayer2)
        {
            rb.MovePosition(rb.position + movement * MoveSpeed * Time.fixedDeltaTime);
        }
        
    }
}
