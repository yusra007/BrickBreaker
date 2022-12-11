using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum colorss { blue, green, red, yellow, cyan }
public class Palets : MonoBehaviour
{
    public colorss color;
   public Animator animator;
    //  is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
