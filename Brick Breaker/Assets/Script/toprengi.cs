using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toprengi : MonoBehaviour
{
    Rigidbody2D rb;
    public float topKuvvet;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rastgeleRenk();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.SetParent(null);
            rb.isKinematic = false;
            rb.AddForce(new Vector2(topKuvvet, topKuvvet));
        }
        


    }
    void rastgeleRenk()
    {
        gameObject.GetComponent<SpriteRenderer>().material.color = Random.ColorHSV(0f,1f,2f,3f,4f,5f,6f,7f);
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        
    }
}
