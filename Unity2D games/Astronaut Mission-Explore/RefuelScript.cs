using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RefuelScript : MonoBehaviour
{
    public Image fuel;
    public Text capacity;
    private float amount;
    private float currentT;
    private float globalT;

    // Update is called once per frame
    void Update()
    {
        capacity.text = BalanceScript.currentFuel.ToString() + "/" + BalanceScript.globalTank.ToString();
        currentT = BalanceScript.currentFuel;
        globalT = BalanceScript.globalTank;
        amount = currentT / globalT;
        fuel.fillAmount = amount;
    }
    public void AddFuel()
    {
        if (BalanceScript.currentFuel < BalanceScript.globalTank)
        {
            BalanceScript.currentFuel += BalanceScript.rfLvl;
            if(BalanceScript.currentFuel > BalanceScript.globalTank)
            {
                BalanceScript.currentFuel = BalanceScript.globalTank;
            }
        }
    }
}
