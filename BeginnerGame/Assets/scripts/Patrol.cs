using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public bool enabled;
    public Rigidbody2D rb;
    public float speed;
    public int Timer = 1000;
    private int Timersafe;
    // Start is called before the first frame update
    void Start()
    {
        enabled = true;
        Timersafe = Timer;
    }

    // Update is called once per frame
    void Update()
    {
        if (enabled&&Timer > 0)
        {
            Patrol1();
            Timer--;
        } 
        if(enabled && Timer<= 0)
        {
            Flip();
            Timer = Timersafe;
        }
    }

    void Patrol1()
    {
        rb.velocity = new Vector2(-speed * Time.fixedDeltaTime, rb.velocity.y);
    }
    void Flip()
    {
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        
        speed *= -1;
    }
}
