using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public int balance;
    public int expereince;

    public int cpuLevel;
    public int gpuLevel;
    public int ramLevel;
    public int fanLevel;
    public int psuLevel;
    public int hddLevel;
    public int motherLevel;
    public int wifiLevel;

    private Global global;
    private ShopContoller shopController;

    private void Start() {
        global = Global.Instance;
        shopController = ShopContoller.Instance;
        LoadPlayer();
       
    }

    public void SavePlayer() {
        balance = global.GetBalance();
        expereince = global.GetExperience();
        
        cpuLevel = shopController.GetCpuLevel();
        gpuLevel = shopController.GetGpuLevel();
        ramLevel = shopController.GetRamLevel();
        fanLevel = shopController.GetFanLevel();
        psuLevel = shopController.GetPsuLevel();
        hddLevel = shopController.GetHddLevel();
        motherLevel = shopController.GetMotherLevel();
        wifiLevel = shopController.GetWifiLevel();
        
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        balance = data.balance;
        global.setBalance(balance);
        
        expereince = data.global_xp;
        global.setExperience(expereince);

        cpuLevel = data.cpuLevel;
        shopController.setCpuLevel(cpuLevel);

        gpuLevel = data.gpuLevel;
        shopController.setGpuLevel(gpuLevel);

        ramLevel = data.ramLevel;
        shopController.setRamLevel(ramLevel);

        fanLevel = data.fanLevel;
        shopController.setCFanLevel(fanLevel);

        psuLevel = data.psuLevel;
        shopController.setPsuLevel(psuLevel);

        hddLevel = data.hddLevel;
        shopController.setHddLevel(hddLevel);

        motherLevel = data.motherLevel;
        shopController.setMotherLevel(motherLevel);

        wifiLevel = data.wifiLevel;
        shopController.setWifiLevel(wifiLevel);
    }
    
}


