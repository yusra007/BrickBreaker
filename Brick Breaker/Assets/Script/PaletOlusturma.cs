using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PaletOlusturma : MonoBehaviour
{
    //public enum renkler { kirmizi, sari, yesil, mor, mavi, turkuaz, pembe, turuncu}

    public int yukseklik;
    public int yatay;
    public List<GameObject> palet;
    toprengi toprengi;
    // Start is called before the first frame update
    void Start()
    {
        olustur();
       
    }
    //public void yoket()
    //{
    //    //int renk;
    //    //switch(renk)
    //    //{
    //    //    case renkler.kirmizi:
    //    //        break;
    //    //}
            
    //}
    
    public void olustur()
    {
        for (int i = 0; i < yukseklik; i++)
        {
            for (int j = 0; j < yatay; j++)
            {
                GameObject gelenObje = Instantiate(palet[Random.Range(0,palet.Count)], new Vector2(i, j), Quaternion.identity);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
   
}
