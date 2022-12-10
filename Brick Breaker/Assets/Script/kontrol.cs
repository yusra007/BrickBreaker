using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum renkler { kirmizi, sari, yesil, mor, mavi, turkuaz, pembe, turuncu }
public class kontrol : MonoBehaviour
{
    [SerializeField] List<RenkBilgi> bilgiList = new List<RenkBilgi>();
    //public renkler renkler;
    toprengi toprengi;
    Dictionary<renkler, Color> renklerDict = new Dictionary<renkler, Color>();
    public List<GameObject> palet;
    public int yukseklik;
    public int yatay;
    // Start is called before the first frame update
    void Start()
    {
        olustur();
    }
    private void Awake()
    {
        if (bilgiList == null || bilgiList.Count == 0)
            return;

        for (int i = 0; i < bilgiList.Count; i++)
        {
            renklerDict.Add(bilgiList[i].renk, bilgiList[i].renkColor);
        }
    }
    public void olustur()
    {
        for (int i = 0; i < yukseklik; i++)
        {
            for (int j = 0; j < yatay; j++)
            {
                GameObject gelenObje = Instantiate(palet[UnityEngine.Random.Range(0, palet.Count)], new Vector2(i, j), Quaternion.identity);
            }
        }
    }
    public Color RenkAl(renkler renkler)
    {
        Color renk;
        renklerDict.TryGetValue(renkler, out renk);
        return renk;
    }
    // Update is called once per frame
    void Update()
    {

    }
    //public static Hashtable hueColourValues = new Hashtable{
    //     { renkler.yesil,     new Color( 0 , 254 , 111, 1 ) },

    //     { renkler.mavi,     new Color( 0 , 122 , 254, 1 ) },
    //     { renkler.turkuaz,     new Color( 0 , 201 , 254, 1 ) },
    //     { renkler.mor, new Color( 143 , 0 , 254, 1 ) },
    //     { renkler.pembe,     new Color( 232 , 0 , 254, 1 ) },
    //     { renkler.kirmizi,     new Color( 254 , 9 , 0, 1 ) },
    //     { renkler.turuncu, new Color( 254 , 161 , 0, 1 ) },
    //     { renkler.sari, new Color( 254 , 224 , 0, 1 ) },

    // };


}
[Serializable]
public class RenkBilgi
{
    public renkler renk;
    public Color renkColor;

}