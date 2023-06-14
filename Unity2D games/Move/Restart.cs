using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
        Coins.scoreShowing = 0;
        GameManager.score = 0;
        Time.timeScale = 1f;
    }

}
