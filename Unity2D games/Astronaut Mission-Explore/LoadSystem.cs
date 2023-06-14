using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSystem : MonoBehaviour
{
    public GameObject balanceScript;
    // Start is called before the first frame update
    void Start()
    {
        balanceScript.GetComponent<BalanceScript>().Load();
    }
}
