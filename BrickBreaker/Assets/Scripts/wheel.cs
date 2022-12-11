using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheel : MonoBehaviour
{

    public List<int> reward;
    public List<AnimationCurve> animationCurves;


    private float anglePerItem;
    private int randomTime;
    private int itemNumber;

    public Animator anim;
    void Start()
    {
      
        anglePerItem = 360 / reward.Count;
    }

    void Update()
    {
        
    }
    public void WheelStart()
    {

        anim.enabled = true;
        randomTime = Random.Range(1, 4);
        itemNumber = Random.Range(0, reward.Count);
        float maxAngle = 360 * randomTime + (itemNumber * anglePerItem);

        StartCoroutine(SpinTheWheel(5 * randomTime, maxAngle));
    }
    public void WheelStop()
    {
        anim.enabled= false;
    }
    IEnumerator SpinTheWheel(float time, float maxAngle)
    {


        float timer = 0.0f;
        float startAngle = transform.eulerAngles.z;
        maxAngle = maxAngle - startAngle;

        int animationCurveNumber = Random.Range(0, animationCurves.Count);
        Debug.Log("Animation Curve No. : " + animationCurveNumber);

        while (timer < time)
        {
          
            float angle = maxAngle * animationCurves[animationCurveNumber].Evaluate(timer / time);
            transform.eulerAngles = new Vector3(0.0f, 0.0f, angle + startAngle);
            timer += Time.deltaTime;
            yield return 0;
        }

        transform.eulerAngles = new Vector3(0.0f, 0.0f, maxAngle + startAngle);


        Debug.Log("Prize: " + reward[itemNumber]);//use prize[itemNumnber] as per requirement
    }
}

