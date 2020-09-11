using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Puck : MonoBehaviour
{
   [SerializeField] Vector2 velocity0 = new Vector2(5f, -3f);
    [SerializeField] Vector2 velocityElse = new Vector2(-5f, 3f);
    [SerializeField] public bool isPlayerBall = false;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
        
        
       
        
    }

   

    // Update is called once per frame
    void Update()
    {
        Direction();

        if(this.transform.position.x >= 10.75f)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
        }
        else if(this.transform.position.x <= -10.75f)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
        }

    }


    public void Direction()
    {
        if(isPlayerBall == true)
        {
            isPlayerBall = false;
            int dIrection;
            dIrection = Random.Range(0, 2);
            if (dIrection == 0)
            {
                rb.velocity = velocity0;
            }
            else
            {
                rb.velocity = velocityElse;
            }
        }
        else
        {
            return;
        }
               
        
    }
}
