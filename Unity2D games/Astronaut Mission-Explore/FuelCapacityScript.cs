using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class FuelCapacityScript : MonoBehaviour
{
    public AudioSource clip1;
    public AudioSource clip2;
    public Image globalf;
    public Image rocketf;
    private bool globalBool;
    private bool rocketBool;
    public Sprite checkSprite;
    public Sprite uncheckSprite;
    public Text totalCapacity;
    public Text globalCapacity;
    public Text rocketCapacity;
    public Text priceTxt;
    private int fuel = 5;
    private int price = 150;

    // Start is called before the first frame update
    void Start()
    {
        globalBool = true;
        rocketBool = false;
        fuel = 5;
        price = 150;
        totalCapacity.text = fuel.ToString();
        priceTxt.text ="Price: " + price.ToString();
    }
    void Update()
    {
        rocketCapacity.text = BalanceScript.rocketTank.ToString() + " liters";
        globalCapacity.text = BalanceScript.globalTank.ToString() + " liters";
    }

    public void GlobalTank()
    {
        globalBool = true;
        rocketBool = false;
        globalf.sprite = checkSprite;
        rocketf.sprite = uncheckSprite;
    }
    public void RocketTank()
    {
        rocketBool = true;
        globalBool = false;
        rocketf.sprite = checkSprite;
        globalf.sprite = uncheckSprite;
    }
    public void AddCapacity()
    {
        if (fuel < 100)
        {
            fuel += 5;
            totalCapacity.text = fuel.ToString();
            price += 150;
            priceTxt.text = "Price: " + price.ToString();
        }
    }
    public void SubtractCapacity()
    {
        if (fuel != 5)
        {
            fuel -= 5;
            totalCapacity.text = fuel.ToString();
            price -= 150;
            priceTxt.text = "Price: " + price.ToString();
        }
    }
    public void UpgradeCapacity()
    {
        if(BalanceScript.balance >= price)
        {
            if(globalBool == true)
            {
                    BalanceScript.balance -= price;
                    BalanceScript.globalTank += fuel;
                    BalanceScript.currentFuel += fuel;
                    clip1.Play();
            }
            else if(rocketBool == true)
            {
                if (BalanceScript.rocketTank + fuel <= BalanceScript.globalTank)
                {
                    BalanceScript.balance -= price;
                    BalanceScript.rocketTank += fuel;
                    clip1.Play();
                }
                else
                clip2.Play();
            }
        }
        else
        {
            clip2.Play();
        }
    }
}
