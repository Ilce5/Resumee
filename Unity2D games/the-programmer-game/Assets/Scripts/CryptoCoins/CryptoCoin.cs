using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;


public class CryptoCoin {
    
    private CryptoCoinSO cryptoCoinSo;
    private float currentPrice;
    private int generations = 0;
    private Queue<float> lastPrices = new Queue<float>();

    public CryptoCoin(CryptoCoinSO newCryptoCoinSo) {
        this.cryptoCoinSo = newCryptoCoinSo;
        currentPrice = newCryptoCoinSo.initialPrice;
    }

    public CryptoCoinSO CryptoCoinSo => cryptoCoinSo;
    public string Name => cryptoCoinSo.cryptoName;
    public string ShortName => cryptoCoinSo.shortHandName;
    public float CurrentPrice => currentPrice;
    public Queue<float> LastPrices => lastPrices;
    

    public void GenerateNewPrice() {
        var variance = cryptoCoinSo.variance;
        float newPrice = currentPrice + currentPrice *(Random.Range(-variance, variance));
        lastPrices.Enqueue(newPrice); // енkueue
        if (lastPrices.Count > 5) {
            lastPrices.Dequeue();
        }
        currentPrice = newPrice;
        generations++;
    }
}