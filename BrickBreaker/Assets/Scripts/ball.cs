using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Path.GUIFramework;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{
    
    Rigidbody2D rb;
    
    public float ballForce=500;
    public GameObject[] palets;
    [SerializeField] colorss colors;
    private SpriteRenderer sr;
    public GameObject playGamePanel,restartgamePanel;
    public Animator anim;
    
    public static bool bittiMi = false;
    Dictionary<colorss,Color> colorssDict=new Dictionary<colorss, Color>();
    Dictionary<Color,colorss> reverseColorssDict=new Dictionary<Color,colorss >();


   [SerializeField] List<UnityEngine.Color> color;

    public static bool isStartGame = false;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
       
        ColorFeature();
        restartgamePanel.SetActive(false);
        RandomColor();
        if(GameManager.isRestart==true)
        {
            bittiMi = true;
                restartgamePanel.SetActive(false);
            rb.isKinematic = true;
        }
        
    }

    public void ColorFeature()
    {
        color.Add(Color.yellow);
        color.Add(Color.green);
        color.Add(Color.red);
        color.Add(Color.blue);
        color.Add(Color.cyan);

        colorssDict.Add(colorss.yellow, Color.yellow);
        colorssDict.Add(colorss.green, Color.green);
        colorssDict.Add(colorss.red, Color.red);
        colorssDict.Add(colorss.blue, Color.blue);
        colorssDict.Add(colorss.cyan, Color.cyan);

        reverseColorssDict.Add(Color.yellow, colorss.yellow);
        reverseColorssDict.Add(Color.green, colorss.green);
        reverseColorssDict.Add(Color.red, colorss.red);
        reverseColorssDict.Add(Color.blue, colorss.blue);
        reverseColorssDict.Add(Color.cyan, colorss.cyan);
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

    
    private void FixedUpdate()
    {
        if (isStartGame == false)
        {

           
           
            return;
        }
    }
    public void startgame ()
    {
        
        isStartGame = true;
        playGamePanel.SetActive(false);
        
       
    }
    
    
  
    public void StartGame()
    {
        
        playGamePanel.SetActive(false);
    }
    void RandomColor()
    {
        Color c = color[Random.Range(0, color.Count)];

        sr.color = c;

        colors = reverseColorssDict[c];
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Palets palet))
        {
            if (palet.color==colors)
            {
                palet.animator.enabled = true;
                paletCreat.Instance.InstantiatedPalets.Remove(collision.gameObject);
                if(paletCreat.Instance.InstantiatedPalets.Count==0)
                {
                    restartgamePanel.SetActive(true);
                    rb.isKinematic=false;
                }
                Destroy(collision.gameObject,1);
                
            }
            //if (palet==null)
            //{
            //    restartgamePanel.SetActive(true);
            //}
            else
            {
                colors =palet.color;
                sr.color = colorssDict[colors];
            }            
        }
    }
    

}
