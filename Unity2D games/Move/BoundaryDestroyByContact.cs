using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryDestroyByContact : MonoBehaviour
{
    public int boundaryScore = 0;
    public void ScoreUp()
    {
        boundaryScore += 1;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name != "Good")
        {
            Destroy(col.gameObject);
        }
    }
}
