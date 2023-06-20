using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    // Start is called before the first frame update
    public int balance;
    public int global_xp;
    
    public int cpuLevel;
    public int gpuLevel;
    public int ramLevel;
    public int fanLevel;
    public int psuLevel;
    public int hddLevel;
    public int motherLevel;
    public int wifiLevel;

    public PlayerData(Player player)
    {
        balance = player.balance;
        global_xp = player.expereince;
        
        cpuLevel = player.cpuLevel;
        gpuLevel = player.gpuLevel;
        ramLevel = player.ramLevel;
        fanLevel = player.fanLevel;
        psuLevel = player.psuLevel;
        hddLevel = player.hddLevel;
        motherLevel = player.motherLevel;
        wifiLevel = player.wifiLevel;
    }
}
