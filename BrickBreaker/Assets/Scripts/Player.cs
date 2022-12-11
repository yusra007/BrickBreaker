using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed=5;
    private float thrust = 300f;
    GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                if (Physics.Raycast(ray))
                {
                    // Create a particle if hit
                    Instantiate(particle, transform.position, transform.rotation);
                }
            }
        }

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


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            rb.AddForce(transform.up * thrust);
            rb.AddForce(transform.up * thrust, ForceMode2D.Impulse);
        }
    }
}
