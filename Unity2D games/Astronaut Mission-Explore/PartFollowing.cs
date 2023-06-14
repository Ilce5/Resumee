using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartFollowing : MonoBehaviour
{
    private float forceApplied;
    private bool forceIt = false;
    private float timer;
    private float timer2;
    private bool stopIt = false;
    private bool stopIt2 = false;
    private int randomRotate;
    // Update is called once per frame
    void Update()
    {
        if(forceIt == true)
        {
            if(stopIt2 == false)
            {
                forceApplied = Random.Range(0.4f, 0.15f);
                stopIt2 = true;
            }
            if (timer < 1.5f)
            {
                transform.position = transform.position - new Vector3(0, forceApplied, 0) * Time.deltaTime;
                timer += Time.deltaTime;
            }
        }
        else
        {
            if(timer > 0)
            {
                transform.position = transform.position + new Vector3(0, forceApplied, 0) * Time.deltaTime;
                timer -= Time.deltaTime;
            }
            else
            {
                stopIt2 = false;
            }
        }
        if(stopIt == false)
        {
            randomRotate = Random.Range(-3, 3);
            if (randomRotate != 0)
            {
                stopIt = true;
            }
        }
        if (timer2 < 3f)
        {
            transform.Rotate(0.0f, 0.0f, randomRotate);
            timer2 += Time.deltaTime;
        }
        else
        {
            stopIt = false;
            timer2 = 0f;
        }
    }
    public void ForceTrue()
    {
        forceIt = true;
    }
    public void ForceFalse()
    {
        forceIt = false;
    }
}
