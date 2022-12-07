using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    Animation anim;
    public GameObject carkpnl;
    public GameObject cark;
    public bool donuyorMu;

    // Start is called before the first frame update
    void Start()
    {
        donuyorMu = false;
        anim = GetComponent<Animation>();
        
        carkcevir();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void carkcevir()
    {
        
    }


}
