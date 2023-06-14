using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class Monetization : MonoBehaviour, IUnityAdsListener
{
    string GooglePlay_ID = "4489023";
    bool GameMode = false;

    public GameObject playCanvas;
    public GameObject menuCanvas;
    public GameObject rewardedDouble;
    public static bool checkReward = false;

    public Image rocket2;
    public GameObject death;
    public GameObject engineParticle;
    public GameObject explodeParticle;
    public Rigidbody2D rb;

    public int moneyToRecieve = 0;

    public Text textToDisplay;

    public static bool revived = false;

    public GameObject resetScript;
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(GooglePlay_ID, GameMode);
        revived = false;
        checkReward = false;
    }

    public void PlayRewardedAdRevive()
    {
        revived = true;
        checkReward = false;
        if (Advertisement.IsReady("Rewarded_Android"))
        {
            Advertisement.Show("Rewarded_Android");
        }
        else
        {
            Debug.Log("Rewarded Ad Not Ready");
        }
    }
    public void PlayRewardedAdDouble()
    {
        revived = false;
        checkReward = true;
        if (Advertisement.IsReady("Rewarded_Android"))
        {
            Advertisement.Show("Rewarded_Android");
        }
        else
        {
            Debug.Log("Rewarded Ad Not Ready");
        }
    }
    public void OnUnityAdsReady(string placementId)
    {
        Debug.Log("Ads are ready");
    }
    public void OnUnityAdsDidError(string message)
    {
        Debug.Log("Error" + message);
    }
    public void OnUnityAdsDidStart(string placementId)
    {
        Debug.Log("Video started");
    }
    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if(placementId == "Rewarded_Android" && showResult == ShowResult.Finished)
        {
            Debug.Log("Player should be rewarded");
            if (checkReward == true)
            {
                resetScript.GetComponent<ResetPlayCanvas>().ResetAd();
                moneyToRecieve = Flying.moneyToInt * 2;
                playCanvas.SetActive(false);
                menuCanvas.SetActive(true);
                rewardedDouble.SetActive(true);
                textToDisplay.text = "Rewarded: " + moneyToRecieve + " Shards";
                BalanceScript.balance += moneyToRecieve;
                checkReward = false;
            }
            else
            {
                rocket2.color = new Color32(255, 255, 255, 255);
                rb.gravityScale = 1f;
                FuelAndTemp.tank = 1f;
                rb.gravityScale = 0f;
                death.SetActive(false);
                engineParticle.SetActive(true);
                explodeParticle.SetActive(false);
                BalanceScript.rocketCurrent = BalanceScript.rocketTank;
            }
        }
    }
    public void OnDestroy()
    {
        Advertisement.RemoveListener(this);
    }
    
}
