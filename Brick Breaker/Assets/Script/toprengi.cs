using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using UnityEditor;
using UnityEngine;




public class toprengi : MonoBehaviour
{
  [SerializeField] renkler topRengi;
    Rigidbody2D rb;
    public float topKuvvet;
    public GameObject[] paletler;
    kontrol kontrol;
    palet palet;
    
   [SerializeField] List<UnityEngine.Color> renkleri;
    //GameObject variableForPrefab;

   
    // Start is called before the first frame update
    void Start()
    {
        //variableForPrefab = Resources.Load("prefabs") as GameObject;
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

        UnityEngine.Color c = renkleri[Random.Range(0, renkleri.Count)];

        gameObject.GetComponent<Renderer>().material.color = c;
        
        
       
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.TryGetComponent(out kontrol kontrol))
        {
            Debug.Log("degdi");

        }

        
    }
}
