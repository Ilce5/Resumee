using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class TapsUpgrade : MonoBehaviour
{
    public AudioSource clip1;
    public AudioSource clip2;
    public Text rfP;
    public Text rfL;

    public Text rpP;
    public Text rpL;

    void Start()
    {
        rfP.text = "Price: " + BalanceScript.rfPrice.ToString();
        rfL.text = "Level: " + BalanceScript.rfLvl.ToString();
        rpP.text = "Price: " + BalanceScript.rpPrice.ToString();
        rpL.text = "Level: " + BalanceScript.rpLvl.ToString();
    }
    public void UpgradeRefuel()
    {
        if(BalanceScript.balance >= BalanceScript.rfPrice)
        {
            clip1.Play();
            BalanceScript.balance -= BalanceScript.rfPrice;
            BalanceScript.rfPrice += 200;
            BalanceScript.rfLvl++;
            rfP.text = "Price: " + BalanceScript.rfPrice.ToString();
            rfL.text = "Level: " + BalanceScript.rfLvl.ToString();
        }
        else
        {
            clip2.Play();
        }
    }
    public void UpgradeRepair()
    {
        if (BalanceScript.balance >= BalanceScript.rpPrice)
        {
            clip1.Play();
            BalanceScript.balance -= BalanceScript.rpPrice;
            BalanceScript.rpClick += BalanceScript.rpBonus;
            BalanceScript.rpPrice += 200;
            BalanceScript.rpLvl++;
            rpP.text = "Price: " + BalanceScript.rpPrice.ToString();
            rpL.text = "Level: " + BalanceScript.rpLvl.ToString();
        }
        else
        {
            clip2.Play();
        }
    }
}
