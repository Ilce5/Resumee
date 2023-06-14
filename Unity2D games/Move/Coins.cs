using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{   
    public static int scoreShowing = 0;
    Text scoreText;
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Good")
        {
            scoreShowing++;
            GameObject.Find("GameManager").GetComponent<GameManager>().ScoreUp();
            Destroy(gameObject);
        }
    }
    void Start()
    {
        scoreText = GetComponent<Text>();
    }
   void Update()
   {
        if (scoreText != null)
        {
            scoreText.text = "Score " + scoreShowing;
        }
    }
}