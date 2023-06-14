using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationUpgrade : MonoBehaviour
{
    public GameObject engine;
    public GameObject rewards;
    public GameObject taps;
    public GameObject fuel;
    private bool check;
    public Animator anim;

    public void CloseAnim()
    {
        anim.Play("Reverse click");
        check = false;
        Invoke("AllOff", 0.3f);
    }
    void AllOff()
    {
        engine.SetActive(false);
        rewards.SetActive(false);
        taps.SetActive(false);
        fuel.SetActive(false);
    }
    public void EngineUp()
    {
        AllOff();
        engine.SetActive(true);
        if (check == false)
        {
            check = true;
            anim.Play("Clicked");
        }
    }

    public void RewardsUp()
    {
        AllOff();
        rewards.SetActive(true);
        if (check == false)
        {
            check = true;
            anim.Play("Clicked");
        }
    }

    public void TapsUp()
    {
        AllOff();
        taps.SetActive(true);
        if (check == false)
        {
            check = true;
            anim.Play("Clicked");
        }
    }

    public void FuelUp()
    {
        AllOff();
        fuel.SetActive(true);
        if (check == false)
        {
            check = true;
            anim.Play("Clicked");
        }
    }
}
