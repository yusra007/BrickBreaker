using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Path.GUIFramework;
using UnityEngine;

public class ball : MonoBehaviour
{
    
    Rigidbody2D rb;
    public float ballForce=250;
    public GameObject[] palets;
    

    [SerializeField] List<UnityEngine.Color> colors;
    //GameObject variableForPrefab;


    // Start is called before the first frame update
    void Start()
    {
        //variableForPrefab = Resources.Load("prefabs") as GameObject;
        rb = GetComponent<Rigidbody2D>();
        RandomColor();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.SetParent(null);
            rb.isKinematic = false;
            rb.AddForce(new Vector2(ballForce, ballForce));
        }



    }
    void RandomColor()
    {

        UnityEngine.Color c = colors[Random.Range(0, colors.Count)];

        gameObject.GetComponent<Renderer>().material.color = c;





    }
}
