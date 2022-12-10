using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed=5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        if (x < 0)
        {
            left();
        }
        if (x > 0)
        {
            right();
        }
        if (x == 0)
        {
            stop();
        }
    }
    void right()
    {
        rb.velocity = new Vector2(speed, 0);
    }
    void left()
    {
        rb.velocity = new Vector2(-speed, 0);
    }

    void stop()
    {
        rb.velocity = Vector2.zero;
    }
}
