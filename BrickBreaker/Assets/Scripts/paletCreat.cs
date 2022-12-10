using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paletCreat : MonoBehaviour
{
    public int height;
    public int flat;
    public List<GameObject> palet;
    
    // Start is called before the first frame update
    void Start()
    {
        creat();

    }
    

    public void creat()
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < flat; j++)
            {
                GameObject gelenObje = Instantiate(palet[Random.Range(0, palet.Count)], new Vector2(i, j), Quaternion.identity);
            }
        }
    }
}
