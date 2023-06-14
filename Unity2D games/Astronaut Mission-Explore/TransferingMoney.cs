using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransferingMoney : MonoBehaviour
{
    private int moneyToTransfer;
    public Text balanceText;

    // Update is called once per frame
    void Update()
    {
        moneyToTransfer = BalanceScript.balance;
        balanceText.text = "Balance: " + moneyToTransfer.ToString() + "Shards";
    }
}
