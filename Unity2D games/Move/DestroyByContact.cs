using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject restartButton;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Good")
        {
            Coins.scoreShowing = 0;
            Destroy(col.gameObject);
            restartButton.SetActive(true);
        }
    }
}
