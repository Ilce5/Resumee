using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class RewardScript : MonoBehaviour
{
    public AudioSource clip1;
    public AudioSource clip2;
    public static float reward = 1f;
    public static int rewardLevel;
    public static int price = 500;
    public Text bonus;
    public Text lvl;
    public Text pricetxt;

    void Start()
    {
        bonus.text = "Bonus: " + BalanceScript.reward.ToString() + "%";
        lvl.text = "Level: " + BalanceScript.rewardLvl.ToString() + "/10";
        pricetxt.text = "Price: " + BalanceScript.rewardPrice.ToString();
    }
    public void UpgradeReward()
    {
        if (BalanceScript.rewardLvl != 10)
        {
            if (BalanceScript.balance >= BalanceScript.rewardPrice)
            {
                clip1.Play();
                BalanceScript.balance -= BalanceScript.rewardPrice;
                BalanceScript.reward += 0.2f;
                BalanceScript.rewardLvl++;
                BalanceScript.rewardPrice += 500;
                bonus.text = "Bonus: " + BalanceScript.reward.ToString() + "%";
                lvl.text = "Level: " + BalanceScript.rewardLvl.ToString() + "/10";
                pricetxt.text = "Price: " + BalanceScript.rewardPrice.ToString();
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
