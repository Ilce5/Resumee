using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public Animator anim;
    public void ChangeIt()
    {
        anim.Play("PlayClick");
        Invoke("NextScene", 0.4f);
    }
    public void ChangeAgain()
    {
        anim.Play("Leaving");
        Invoke("BackScene", 0.5f);
        BalanceScript.playAnimation = 1;
    }
    public void ChangePlay()
    {
        anim.Play("Leaving");
        Invoke("BackScene", 0.5f);
        BalanceScript.playAnimation = 3;
    }
    public void ChangeBlackhole()
    {
        Invoke("ThirdScene", 0.4f);
        anim.Play("FadeOn");
    }
    void NextScene()
    {
        SceneManager.LoadScene("PlayScene");
    }
    public void BackScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void ThirdScene()
    {
        SceneManager.LoadScene("BlackholeScene");
    }
}
