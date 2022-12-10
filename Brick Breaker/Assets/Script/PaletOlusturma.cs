////using System.Collections;
////using System.Collections.Generic;
////using System.Diagnostics;
////using UnityEngine;

//public class PaletOlusturma : MonoBehaviour
//{

//    public int yukseklik;
//    public int yatay;
//    public List<GameObject> palet;
//    toprengi toprengi;
//    // Start is called before the first frame update
//    void Start()
//    {
//        olustur();

//    }
//    public void yoket()
//    {


//    }

//    public void olustur()
//    {
//        for (int i = 0; i < yukseklik; i++)
//        {
//            for (int j = 0; j < yatay; j++)
//            {
//                GameObject gelenObje = Instantiate(palet[Random.Range(0, palet.Count)], new Vector2(i, j), Quaternion.identity);
//            }
//        }
//    }
//    private void OnCollisionEnter2D(Collision2D collision)
//    {

//    }


//}
