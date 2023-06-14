using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winText;
    public GameObject pauseWin;
    public static int score = 0;

    public void ScoreUp()
    {
        score++;
        if (score >= 40)
        {
            Win();
        }
    }
    void Win()
    {
        winText.SetActive(true);
        pauseWin.SetActive(true);
        Pause();
    }
    public void Pause()
    {
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        Time.timeScale = 1f;
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
