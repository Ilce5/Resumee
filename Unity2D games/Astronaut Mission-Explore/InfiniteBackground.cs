using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteBackground : MonoBehaviour
{
    public Transform bg1;
    public Transform bg2;
    public Transform rocket;
    private float y1;
    private float y2;
    public static bool checkIt = false;
    private bool gotIt = false;

    void Update()
    {
        if(checkIt == false)
        {
            if (gotIt == false)
            {
                y1 = bg1.position.y;
                y2 = bg2.position.y;
                gotIt = true;
            }
            Reset();
            checkIt = true;
        }
        if (rocket.position.y >= bg2.position.y && bg1.position.y < bg2.position.y)
        {
            bg1.position = new Vector3(bg1.position.x, bg2.position.y + 39.48702f, bg1.position.z);
        }
        else if (rocket.position.y >= bg1.position.y && bg2.position.y < bg1.position.y)
        {
            bg2.position = new Vector3(bg2.position.x, bg1.position.y + 39.48702f, bg2.position.z);
        }
    }
    
    void Reset()
    {
        bg1.position = new Vector3(bg1.position.x, y1, bg1.position.z);
        bg2.position = new Vector3(bg2.position.x, y2, bg2.position.z);
    }
}
