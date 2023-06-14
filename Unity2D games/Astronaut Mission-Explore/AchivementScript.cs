using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchivementScript : MonoBehaviour
{
    public Image r1;
    public Image r2;
    public Image r3;
    public Image r4;
    public Image r5;

    public Image p1;
    public Image p2;
    public Image p3;
    public Image p4;
    public Image p5;

    public Image b1;
    public Image b2;
    public Image b3;
    public Image b4;
    public Image b5;

    public Image l1;
    public Image l2;
    public Image l3;
    public Image l4;
    public Image l5;

    public Image g1;
    public Image g2;
    public Image g3;
    public Image g4;
    public Image g5;

    public Image level;
    public Image level2;

    public Sprite lvl2;
    public Sprite lvl3;
    public Sprite lvl4;
    public Sprite lvl5;

    private bool check2 = false;
    private bool check3 = false;
    private bool check4 = false;
    private bool check5 = false;
    private bool waitForIt = false;

    private float transformAchivement;

    public Text levelTxt;
    public Text achivementTxt;

    // Update is called once per frame
    void Update()
    {
        if (waitForIt == false)
        {
            BalanceScript.currentAchivement = transformAchivement;
            BalanceScript.profileLevel = BalanceScript.currentAchivement / 5f;
        }
        level.fillAmount = BalanceScript.profileLevel;
        level2.fillAmount = BalanceScript.profileLevel;
        BalanceScript.totalAchivement = BalanceScript.achivement1 + BalanceScript.achivement2 + BalanceScript.achivement3 + BalanceScript.achivement4 + BalanceScript.achivement5;

        if (BalanceScript.totalAchivement >= 5 && BalanceScript.totalAchivement < 10)
        {
            transformAchivement = BalanceScript.totalAchivement % 5;
            achivementTxt.text = BalanceScript.totalAchivement + "/10";
            if (check2 == false)
            {
                waitForIt = true;
                level.sprite = lvl2;
                level2.sprite = lvl2;
                BalanceScript.profileLevel -= 0.5f * Time.deltaTime;
                if (BalanceScript.profileLevel <= 0f)
                {
                    waitForIt = false;
                    check2 = true;
                    levelTxt.text = "Level: 2";
                }
            }
        }
        else if (BalanceScript.totalAchivement >= 10 && BalanceScript.totalAchivement < 15)
        {
            transformAchivement = BalanceScript.totalAchivement % 10;
            achivementTxt.text = BalanceScript.totalAchivement + "/15";
            if (check3 == false)
            {
                waitForIt = true;
                level.sprite = lvl3;
                level2.sprite = lvl3;
                BalanceScript.profileLevel -= 0.5f * Time.deltaTime;
                if (BalanceScript.profileLevel <= 0f)
                {
                    waitForIt = false;
                    check3 = true;
                    levelTxt.text = "Level: 3";
                }
            }
        }
        else if (BalanceScript.totalAchivement >= 15 && BalanceScript.totalAchivement < 20)
        {
            transformAchivement = BalanceScript.totalAchivement % 15;
            achivementTxt.text = BalanceScript.totalAchivement + "/20";
            if (check4 == false)
            {
                waitForIt = true;
                level.sprite = lvl4;
                level2.sprite = lvl4;
                BalanceScript.profileLevel -= 0.5f * Time.deltaTime;
                if (BalanceScript.profileLevel <= 0f)
                {
                    waitForIt = false;
                    check4 = true;
                    levelTxt.text = "Level: 4";
                }
            }
        }
        else if(BalanceScript.totalAchivement >=20)
        {
            transformAchivement = BalanceScript.totalAchivement % 20;
            achivementTxt.text = BalanceScript.totalAchivement + "/25";
            if (check5 == false)
            {
                waitForIt = true;
                level.sprite = lvl5;
                level2.sprite = lvl5;
                BalanceScript.profileLevel -= 0.5f * Time.deltaTime;
                if (BalanceScript.profileLevel <= 0f)
                {
                    waitForIt = false;
                    check5 = true;
                    levelTxt.text = "Level: 5";
                }
            }
        }
        else
        {
            achivementTxt.text = BalanceScript.totalAchivement + "/5";
            transformAchivement = BalanceScript.totalAchivement;
        }
        Checkit();
      
    }

    public void Checkit()
    {
        //Top Speed
        if(BalanceScript.topSpeed >= 25f) {
            r1.color = new Color32(255, 0, 0, 225);
            BalanceScript.achivement1 = 1;
            if (BalanceScript.topSpeed >= 35f)
            {
                r2.color = new Color32(255, 0, 0, 225);
                BalanceScript.achivement1 = 2;
                if (BalanceScript.topSpeed >= 50f)
                {
                    r3.color = new Color32(255, 0, 0, 225);
                    BalanceScript.achivement1 = 3;
                    if (BalanceScript.topSpeed >= 75f)
                    {
                        r4.color = new Color32(255, 0, 0, 225);
                        BalanceScript.achivement1 = 4;
                        if (BalanceScript.topSpeed >= 100f)
                        {
                            r5.color = new Color32(255, 0, 0, 225);
                            BalanceScript.achivement1 = 5;
                        }
                    }
                }

            }
        }
        //Unlocked Planets
        if(BalanceScript.unlockedPlanets >= 2)
        {
            p1.color = new Color32(255, 0, 255, 225);
            BalanceScript.achivement2 = 1;
            if (BalanceScript.unlockedPlanets >= 4)
            {
                p2.color = new Color32(255, 0, 255, 225);
                BalanceScript.achivement2 = 2;
                if (BalanceScript.unlockedPlanets >= 6)
                {
                    p3.color = new Color32(255, 0, 255, 225);
                    BalanceScript.achivement2 = 3;
                    if (BalanceScript.unlockedPlanets >= 8)
                    {
                        p4.color = new Color32(255, 0, 255, 225);
                        BalanceScript.achivement2 = 4;
                        if (BalanceScript.unlockedPlanets >= 9)
                        {
                            p5.color = new Color32(255, 0, 255, 225);
                            BalanceScript.achivement2 = 5;
                        }
                    }
                }
            }
        }
        //Purchased Rockets
        if(BalanceScript.purchasedRockets >= 2)
        {
            b1.color = new Color32(0, 0, 255, 255);
            BalanceScript.achivement3 = 1;
            if (BalanceScript.purchasedRockets >= 4)
            {
                b2.color = new Color32(0, 0, 255, 255);
                BalanceScript.achivement3 = 2;
                if (BalanceScript.purchasedRockets >= 6)
                {
                    b3.color = new Color32(0, 0, 255, 255);
                    BalanceScript.achivement3 = 3;
                    if (BalanceScript.purchasedRockets >= 8)
                    {
                        b4.color = new Color32(0, 0, 255, 255);
                        BalanceScript.achivement3 = 4;
                        if (BalanceScript.purchasedRockets >= 10)
                        {
                            b5.color = new Color32(0, 0, 255, 255);
                            BalanceScript.achivement3 = 5;
                        }
                    }
                }
            }
        }
        //Upgraded Engine
        if(BalanceScript.upgradedEngine >= 10)
        {
            l1.color = new Color32(0, 255, 255, 255);
            BalanceScript.achivement4 = 1;
            if (BalanceScript.upgradedEngine >= 20)
            {
                l2.color = new Color32(0, 255, 255, 255);
                BalanceScript.achivement4 = 2;
                if (BalanceScript.upgradedEngine >= 30)
                {
                    l3.color = new Color32(0, 255, 255, 255);
                    BalanceScript.achivement4 = 3;
                    if (BalanceScript.upgradedEngine >= 40)
                    {
                        l4.color = new Color32(0, 255, 255, 255);
                        BalanceScript.achivement4 = 4;
                        if (BalanceScript.upgradedEngine >= 50)
                        {
                            l5.color = new Color32(0, 255, 255, 255);
                            BalanceScript.achivement4 = 5;
                        }
                    }
                }
            }
        }
        //Repair Clicks
        if(BalanceScript.repairedClicks >= 200)
        {
            g1.color = new Color32(0, 255, 0, 255);
            BalanceScript.achivement5 = 1;
            if (BalanceScript.repairedClicks >= 500)
            {
                g2  .color = new Color32(0, 255, 0, 255);
                BalanceScript.achivement5 = 2;
                if (BalanceScript.repairedClicks >= 900)
                {
                    g3.color = new Color32(0, 255, 0, 255);
                    BalanceScript.achivement5 = 3;
                    if (BalanceScript.repairedClicks >= 1500)
                    {
                        g4.color = new Color32(0, 255, 0, 255);
                        BalanceScript.achivement5 = 4;
                        if (BalanceScript.repairedClicks >= 2000)
                        {
                            g5.color = new Color32(0, 255, 0, 255);
                            BalanceScript.achivement5 = 5;
                        }
                    }
                }
            }
        }
    }
}
