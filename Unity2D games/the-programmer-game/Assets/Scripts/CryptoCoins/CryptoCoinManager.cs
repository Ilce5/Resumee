using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class CryptoCoinManager : MonoBehaviour
{ 
    public static CryptoCoinManager Instance { get; private set; }
    private  CryptoCoinListSO cryptoCoinListSO;
    private  List<CryptoCoin> cryptoCoinInstances = new List<CryptoCoin>();

    private float timer = 0;
    public void Awake() {
        Instance = this;
        cryptoCoinListSO = Resources.Load<CryptoCoinListSO>("CryptoList");

        foreach (var cryptoCoinSO in cryptoCoinListSO.list) {
            cryptoCoinInstances.Add(new CryptoCoin(cryptoCoinSO));
        }
    }
    

    public  Dictionary<CryptoCoinSO, float> GetCurrentPrices () {
        var CENA = new Dictionary<CryptoCoinSO, float>();
        foreach (var crpytoCoin in cryptoCoinInstances) {
            CENA[crpytoCoin.CryptoCoinSo] = crpytoCoin.CurrentPrice; // klasik
        }
        return CENA;
    }

    private void Update() {
        timer += Time.deltaTime;
        if (timer >= 2) {
            timer -=2;
            foreach (var crpytoCoin in cryptoCoinInstances) {
                crpytoCoin.GenerateNewPrice();
            }
            string s = string.Join(";", cryptoCoinInstances.Select(x => x.ShortName + "=" + x.CurrentPrice).ToArray());
            print(s);
        }
    }
}
