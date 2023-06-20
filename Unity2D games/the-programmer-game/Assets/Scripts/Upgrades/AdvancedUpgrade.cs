using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdvancedUpgrade : MonoBehaviour
{
    public Animator anim;

    private bool checkU1 = false;
    private bool checkU2 = false;
    private bool checkU3 = false;
    private bool checkU4 = false;
    private bool checkU5 = false;
    private bool checkU6 = false;
    private bool checkU7 = false;
    private bool checkU8 = false;
    private bool checkU9 = false;

    public Text nameOfUpgrade;
    public Text buyButtonText;
    public GameObject notif;
    public GameObject noXp;
    public Sprite fullUpgrade;
    private bool exitCheck = false;
    private int xpBalanceint = 5000;

    public int priceOfRan = 600;
    public int priceOfFin = 600;
    public int priceOfBin = 600;
    public int priceOfDyn = 600;
    public int priceOfNet = 600;
    public int priceOfLin = 600;
    public int priceOfStr = 600;
    public int priceOfData = 600;
    public int priceOfWord = 600;

    public void Randomization()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("AdvancedAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Randomization";
        buyButtonText.text = "Buy for " + priceOfRan.ToString() + "xp";
    }
    public void Fingerprinting()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("AdvancedAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Fingerprinting";
        buyButtonText.text = "Buy for " + priceOfFin.ToString() + "xp";
    }
    public void BinaryScaling()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("AdvancedAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Binary scaling";
        buyButtonText.text = "Buy for " + priceOfBin.ToString() + "xp";
    }
    public void DynamicProgramming()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("AdvancedAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Dynamic programming";
        buyButtonText.text = "Buy for " + priceOfDyn.ToString() + "xp";
    }
    public void NetworkFlow()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("AdvancedAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Network flow";
        buyButtonText.text = "Buy for " + priceOfNet.ToString() + "xp";
    }
    public void LinearProgramming()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("AdvancedAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Linear programming";
        buyButtonText.text = "Buy for " + priceOfLin.ToString() + "xp";
    }
    public void StreamingAlgorithms()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("AdvancedAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Streaming algorithms";
        buyButtonText.text = "Buy for " + priceOfStr.ToString() + "xp";
    }
    public void DataStructures()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("AdvancedAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Data structures";
        buyButtonText.text = "Buy for " + priceOfData.ToString() + "xp";
    }
    public void Parallelism()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("AdvancedAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Word-level parallelism";
        buyButtonText.text = "Buy for " + priceOfWord.ToString() + "xp";
    }

    public void Bought()
    {
        if (nameOfUpgrade.text == "Randomization")
        {
            if (checkU1 == false)
            {
                if (xpBalanceint >= priceOfRan)
                {
                    checkU1 = true;
                    xpBalanceint -= priceOfRan;
                    upgrade1.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }

        }
        else if (nameOfUpgrade.text == "Fingerprinting")
        {
            if (checkU2 == false)
            {
                if (xpBalanceint >= priceOfFin)
                {
                    checkU2 = true;
                    xpBalanceint -= priceOfFin;
                    upgrade2.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Binary scaling")
        {
            if (checkU3 == false)
            {
                if (xpBalanceint >= priceOfBin)
                {
                    checkU3 = true;
                    xpBalanceint -= priceOfBin;
                    upgrade3.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Dynamic programming")
        {
            if (checkU4 == false)
            {
                if (xpBalanceint >= priceOfDyn)
                {
                    checkU4 = true;
                    xpBalanceint -= priceOfDyn;
                    upgrade4.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Network flow")
        {
            if (checkU5 == false)
            {
                if (xpBalanceint >= priceOfNet)
                {
                    checkU5 = true;
                    xpBalanceint -= priceOfNet;
                    upgrade5.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Linear programming")
        {
            if (checkU6 == false)
            {
                if (xpBalanceint >= priceOfLin)
                {
                    checkU6 = true;
                    xpBalanceint -= priceOfLin;
                    upgrade6.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Streaming algorithms")
        {
            if (checkU7 == false)
            {
                if (xpBalanceint >= priceOfStr)
                {
                    checkU7 = true;
                    xpBalanceint -= priceOfStr;
                    upgrade7.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Data structures")
        {
            if (checkU8 == false)
            {
                if (xpBalanceint >= priceOfData)
                {
                    checkU8 = true;
                    xpBalanceint -= priceOfData;
                    upgrade8.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Word-level parallelism")
        {
            if (checkU9 == false)
            {
                if (xpBalanceint >= priceOfWord)
                {
                    checkU9 = true;
                    xpBalanceint -= priceOfWord;
                    upgrade9.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
    }

    public void Exitit()
    {
        anim.Play("ReverseAdvancedAnimation");
        Invoke("DelayExit", 0.4f);
    }

    private void DelayExit()
    {
        exitCheck = false;
        notif.SetActive(false);
    }






    public Image upgrade1;
    public Image upgrade2;
    public Image upgrade3;
    public Image upgrade4;
    public Image upgrade5;
    public Image upgrade6;
    public Image upgrade7;
    public Image upgrade8;
    public Image upgrade9;
}
