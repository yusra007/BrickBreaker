using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paletCreat : MonoBehaviour
{
    public ball ball;
    public int height;
    public int flat;
    public List<GameObject> palet;
    public List<GameObject> InstantiatedPalets;
    public static paletCreat Instance;
    // Start is called before the first frame update

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        ball.restartgamePanel.SetActive(false);
        creat();

    }
    
    

    public void creat()
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < flat; j++)
            {
                GameObject gelenObje = Instantiate(palet[Random.Range(0, palet.Count)], new Vector2(i, j), Quaternion.identity);
                InstantiatedPalets.Add(gelenObje);
                
                
            }
        }
        
    }
    
}
