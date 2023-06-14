using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Upgradescript : MonoBehaviour
{
    public AudioSource clip1;
    public AudioSource clip2;

    public Text etxt;
    public Image eimage;

    public Text ctxt;
    public Image cimage;
    
    public Text ptxt;
    public Image pimage;

    public Text dtxt;
    public Image dimage;

    public Text btxt;
    public Image bimage;



    // Start is called before the first frame update
    void Start()
    {
        eimage.fillAmount = BalanceScript.elvl / 10;
        etxt.text = BalanceScript.ePrice.ToString();

        cimage.fillAmount = BalanceScript.clvl / 10;
        ctxt.text = BalanceScript.cPrice.ToString();

        pimage.fillAmount = BalanceScript.plvl / 10;
        ptxt.text = BalanceScript.pPrice.ToString();

        dimage.fillAmount = BalanceScript.dlvl / 10;
        dtxt.text = BalanceScript.dPrice.ToString();

        bimage.fillAmount = BalanceScript.blvl / 10;
        btxt.text = BalanceScript.bPrice.ToString();
    }

    public void BuyEfficency()
    {
        if (BalanceScript.balance >= BalanceScript.ePrice)
        {
            if(BalanceScript.elvl != 10)
            {
                clip1.Play();
                BalanceScript.upgradedEngine++;
                BalanceScript.balance -= BalanceScript.ePrice;
                BalanceScript.consumption -= 0.5f;
                BalanceScript.ePrice += 350;
                BalanceScript.elvl++;
                eimage.fillAmount = BalanceScript.elvl / 10;
                etxt.text = BalanceScript.ePrice.ToString();
            }
            else
            {
                clip2.Play();
            }
        }
        else
        {
            clip2.Play();
        }
    }

    public void BuyCool()
    {
        if (BalanceScript.balance >= BalanceScript.cPrice)
        {
            if (BalanceScript.clvl != 10)
            {
                clip1.Play();
                BalanceScript.upgradedEngine++;
                BalanceScript.balance -= BalanceScript.cPrice;
                BalanceScript.cooling += 0.04f;
                BalanceScript.cPrice += 350;
                BalanceScript.clvl++;
                cimage.fillAmount = BalanceScript.clvl / 10;
                ctxt.text = BalanceScript.cPrice.ToString();
            }
            else
            {
                clip2.Play();
            }
        }
        else
        {
            clip2.Play();
        }
    }

    public void BuyPerformance()
    {
        if (BalanceScript.balance >= BalanceScript.pPrice)
        {
            if (BalanceScript.plvl != 10)
            {
                clip1.Play();
                BalanceScript.upgradedEngine++;
                BalanceScript.balance -= BalanceScript.pPrice;
                BalanceScript.speedFly += 20f;
                BalanceScript.pPrice += 350;
                BalanceScript.plvl++;
                pimage.fillAmount = BalanceScript.plvl / 10;
                ptxt.text = BalanceScript.pPrice.ToString();
            }
            else
            {
                clip2.Play();
            }
        }
        else
        {
            clip2.Play();
        }
    }

    public void BuyDurability()
    {
        if (BalanceScript.balance >= BalanceScript.dPrice)
        {
            if (BalanceScript.dlvl != 10)
            {
                clip1.Play();
                BalanceScript.upgradedEngine++;
                BalanceScript.balance -= BalanceScript.dPrice;
                BalanceScript.maxDamage -= 0.015f;
                BalanceScript.minDamage -= 0.005f;
                BalanceScript.dPrice += 250;
                BalanceScript.dlvl++;
                dimage.fillAmount = BalanceScript.dlvl / 10;
                dtxt.text = BalanceScript.dPrice.ToString();
            }
            else
            {
                clip2.Play();
            }
        }
        else
        {
            clip2.Play();
        }
    }

    public void BuyBoost()
    {
        if (BalanceScript.balance >= BalanceScript.bPrice)
        {
            if (BalanceScript.blvl != 10)
            {
                clip1.Play();
                BalanceScript.upgradedEngine++;
                BalanceScript.balance -= BalanceScript.bPrice;
                BalanceScript.boostSpeed += 50f;
                BalanceScript.bPrice += 250;
                BalanceScript.blvl++;
                bimage.fillAmount = BalanceScript.blvl / 10;
                btxt.text = BalanceScript.bPrice.ToString();
            }
            else
            {
                clip2.Play();
            }
        }
        else
        {
                clip2.Play();
        }
    }
}
