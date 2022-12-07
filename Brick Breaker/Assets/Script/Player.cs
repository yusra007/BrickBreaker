using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float hiz;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       float x = Input.GetAxis("Horizontal");
        if(x<0)
        {
            sol();
        }
        if(x>0)
        {
            sag();  
        }
        if(x==0)
        {
            dur();
        }
    }
    void sag()
    {
        rb.velocity = new Vector2(hiz, 0);
    }
    void sol()
    {
        rb.velocity = new Vector2(-hiz, 0);
    }

    void dur()
    {
        rb.velocity = Vector2.zero;
    }
}
