using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class MonetizationUpgrade : MonoBehaviour, IUnityAdsListener
{
    string GooglePlay_ID = "4489023";
    bool GameMode = false;

    private float addedRepair = 0f;
    public GameObject repairScript;

    void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(GooglePlay_ID, GameMode);
    }

    public void PlayRewarded()
    {
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
        if (placementId == "Rewarded_Android" && showResult == ShowResult.Finished)
        {
            Debug.Log("Player should be rewarded");
            Debug.Log(BalanceScript.air);
            if (BalanceScript.repairedClicks < 200)
            {
                addedRepair = 0.50f;
            }else if (BalanceScript.repairedClicks < 500)
            {
                addedRepair = 0.60f;
            }else if (BalanceScript.repairedClicks < 1500)
            {
                addedRepair = 0.70f;
            }else
            {
                addedRepair = 0.80f;
            }

            if (BalanceScript.air + addedRepair <= 1f)
            {
                Debug.Log("Less " + addedRepair);
                BalanceScript.air += addedRepair;
            }else
            {
                Debug.Log("More");
                BalanceScript.air = 1f;
            }
            Debug.Log(BalanceScript.air);

            if (BalanceScript.cooler + addedRepair <= 1f)
            {
                BalanceScript.cooler += addedRepair;
            }else
            {
                BalanceScript.cooler = 1f;
            }

            if (BalanceScript.compressor + addedRepair <= 1f)
            {
                BalanceScript.compressor += addedRepair;
            }else
            {
                BalanceScript.compressor = 1f;
            }

            if (BalanceScript.turbine + addedRepair <= 1f)
            {
                BalanceScript.turbine += addedRepair;
            }else
            {
                BalanceScript.turbine = 1f;
            }

            if (BalanceScript.engine + addedRepair <= 1f)
            {
                BalanceScript.engine += addedRepair;
            }else
            {
                BalanceScript.engine = 1f;
            }

            if (BalanceScript.ramjet + addedRepair <= 1f)
            {
                BalanceScript.ramjet += addedRepair;
            }else
            {
                BalanceScript.ramjet = 1f;
            }

            if (BalanceScript.nozzle + addedRepair <= 1f)
            {
                BalanceScript.nozzle += addedRepair;
            }else
            {
                BalanceScript.nozzle = 1f;
            }
            repairScript.GetComponent<RepairScript>().UpdateImage();
        }
    }
    public void OnDestroy()
    {
        Advertisement.RemoveListener(this);
    }
}
