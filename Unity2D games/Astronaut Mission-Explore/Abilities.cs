using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Abilities : MonoBehaviour
{
    public Image ability1;
    public GameObject circle1;
    private static bool available1 = false;
    private bool check1 = false;

    public Image ability2;
    public GameObject circle2;
    private static bool available2 = false;
    private bool check2 = false;

    public Image ability3;
    public GameObject circle3;
    private static bool available3 = false;
    private bool check3 = false;

    public Image ability4;
    public GameObject circle4;
    private static bool available4 = false;
    private bool check4 = false;

    public Image ability5;
    public GameObject circle5;
    private static bool available5 = false;
    private bool check5 = false;

    public AudioSource confirmed;
    public AudioSource notconfirmed;

    // Start is called before the first frame update
    void Start()
    {
        if(BalanceScript.purchasedRockets >= 2)
        {
            ability1.color = new Color32(255, 255, 255, 255);
            available1 = true;
        }
        if(BalanceScript.purchasedRockets >= 4)
        {
            ability2.color = new Color32(255, 255, 255, 255);
            available2 = true;
        }
        if(BalanceScript.purchasedRockets >= 6)
        {
            ability3.color = new Color32(255, 255, 255, 255);
            available3 = true;
        }
        if(BalanceScript.purchasedRockets >= 8)
        {
            ability4.color = new Color32(255, 255, 255, 255);
            available4 = true;
        }
        if(BalanceScript.purchasedRockets >= 10)
        {
            ability5.color = new Color32(255, 255, 255, 255);
            available5 = true;
        }
    }

    public void CoolingSystem()
    {
        if (available1 == true && check1 == false)
        {
            TurnOffCircles();
            circle1.SetActive(true);
            check1 = true;
            BalanceScript.cooling += 0.05f;
            confirmed.Play();
        }
        else
        {
            notconfirmed.Play();
        }
    }
    public void MoneyMultiplier()
    {
        if (available2 == true && check2 == false)
        {
            TurnOffCircles();
            circle2.SetActive(true);
            check2 = true;
            BalanceScript.reward += 0.2f;
            confirmed.Play();
        }
        else
        {
            notconfirmed.Play();
        }
    }
    public void Shield()
    {
        if (available3 == true && check3 == false)
        {
            TurnOffCircles();
            circle3.SetActive(true);
            check3 = true;
            BalanceScript.maxDamage -= 0.01f;
            confirmed.Play();
        }
        else
        {
            notconfirmed.Play();
        }
    }
    public void ThrustPower()
    {
        if (available4 == true && check4 == false)
        {
            TurnOffCircles();
            circle4.SetActive(true);
            check4 = true;
            BalanceScript.boostSpeed += 25f;
            confirmed.Play();
        }
        else
        {
            notconfirmed.Play();
        }
    }
    public void AdditionalFuel()
    {
        if (available5 == true && check5 == false)
        {
            TurnOffCircles();
            circle5.SetActive(true);
            check5 = true;
            BalanceScript.rocketTank += 20;
            confirmed.Play();
        }
        else
        {
            notconfirmed.Play();
        }
    }

    void TurnOffCircles()
    {
        circle1.SetActive(false);
        circle2.SetActive(false);
        circle3.SetActive(false);
        circle4.SetActive(false);
        circle5.SetActive(false);
        if(check1 == true)
        {
            BalanceScript.cooling -= 0.05f;
            check1 = false;
        }else if(check2 == true)
        {
            BalanceScript.reward -= 0.2f;
            check2 = false;
        }else if(check3 == true)
        {
            BalanceScript.maxDamage += 0.01f;
            check3 = false;
        }else if(check4 == true)
        {
            BalanceScript.boostSpeed -= 25f;
            check4 = false;
        }else if(check5 == true)
        {
            BalanceScript.rocketTank -= 20;
            check5 = false;
        }
    }
}
