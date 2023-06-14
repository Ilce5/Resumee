 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    public Transform bg1;
    private float pos = 1.15f;

    // Start is called before the first frame update
   // void Start()
    //{
        //pos = 1.291f;
   // }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (pos <= -6.7f)
        { 
            pos = 1.291f;
        } 
        else
        {
            pos -= 0.01f * Time.deltaTime;
        }
        bg1.localPosition = new Vector3 (pos, bg1.position.y, 10f);

    }
}
