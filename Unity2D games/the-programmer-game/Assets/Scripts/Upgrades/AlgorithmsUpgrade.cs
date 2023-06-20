using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlgorithmsUpgrade : MonoBehaviour
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

    public int priceOfBub = 600;
    public int priceOfEucl = 600;
    public int priceOfLinear = 600;
    public int priceOfPrime = 600;
    public int priceOfFib = 600;
    public int priceOfRec = 600;
    public int priceOfBreadth = 600;
    public int priceOfBinary = 600;
    public int priceOfDepth = 600;

    public void BubbleSort()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("AlgorithmsNotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Bubble sort";
        buyButtonText.text = "Buy for " + priceOfBub.ToString() + "xp";
    }
    public void EuclideanAlgorithm()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("AlgorithmsNotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Euclidean algorithm";
        buyButtonText.text = "Buy for " + priceOfEucl.ToString() + "xp";
    }
    public void LinearSearch()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("AlgorithmsNotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Linear search";
        buyButtonText.text = "Buy for " + priceOfLinear.ToString() + "xp";
    }
    public void PrimeFactorsAlgorithm()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("AlgorithmsNotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Prime factors algorithm";
        buyButtonText.text = "Buy for " + priceOfPrime.ToString() + "xp";
    }
    public void FibonacciAlgorithm()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("AlgorithmsNotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Fibonacci algorithm";
        buyButtonText.text = "Buy for " + priceOfFib.ToString() + "xp";
    }
    public void RecursiveFactorial()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("AlgorithmsNotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Recursive factorial";
        buyButtonText.text = "Buy for " + priceOfRec.ToString() + "xp";
    }
    public void BreadthFirstSearch()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("AlgorithmsNotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Breadth-first search";
        buyButtonText.text = "Buy for " + priceOfBreadth.ToString() + "xp";
    }
    public void BinarySearch()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("AlgorithmsNotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Binary search";
        buyButtonText.text = "Buy for " + priceOfBinary.ToString() + "xp";
    }
    public void DepthFirstSearch()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("AlgorithmsNotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Depth-first search";
        buyButtonText.text = "Buy for " + priceOfDepth.ToString() + "xp";
    }
    public void Bought()
    {
        if (nameOfUpgrade.text == "Bubble sort")
        {
            if (checkU1 == false)
            {
                if (xpBalanceint >= priceOfBub)
                {
                    checkU1 = true;
                    xpBalanceint -= priceOfBub;
                    upgrade1.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }

        }
        else if (nameOfUpgrade.text == "Euclidean algorithm")
        {
            if (checkU2 == false)
            {
                if (xpBalanceint >= priceOfEucl)
                {
                    checkU2 = true;
                    xpBalanceint -= priceOfEucl;
                    upgrade2.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Linear search")
        {
            if (checkU3 == false)
            {
                if (xpBalanceint >= priceOfLinear)
                {
                    checkU3 = true;
                    xpBalanceint -= priceOfLinear;
                    upgrade4.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Prime factors algorithm")
        {
            if (checkU4 == false)
            {
                if (xpBalanceint >= priceOfPrime)
                {
                    checkU4 = true;
                    xpBalanceint -= priceOfPrime;
                    upgrade5.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Fibonacci algorithm")
        {
            if (checkU5 == false)
            {
                if (xpBalanceint >= priceOfFib)
                {
                    checkU5 = true;
                    xpBalanceint -= priceOfFib;
                    upgrade7.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Recursive factorial")
        {
            if (checkU6 == false)
            {
                if (xpBalanceint >= priceOfRec)
                {
                    checkU6 = true;
                    xpBalanceint -= priceOfRec;
                    upgrade8.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Breadth-first search")
        {
            if (checkU7 == false)
            {
                if (xpBalanceint >= priceOfBreadth)
                {
                    checkU7 = true;
                    xpBalanceint -= priceOfBreadth;
                    upgrade3.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Binary search")
        {
            if (checkU8 == false)
            {
                if (xpBalanceint >= priceOfBinary)
                {
                    checkU8 = true;
                    xpBalanceint -= priceOfBinary;
                    upgrade6.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Depth-first search")
        {
            if (checkU9 == false)
            {
                if (xpBalanceint >= priceOfDepth)
                {
                    checkU9 = true;
                    xpBalanceint -= priceOfDepth;
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
        anim.Play("ReverseAlgorithmsNotificationAnimation");
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
