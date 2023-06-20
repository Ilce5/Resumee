using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class ShopContoller : MonoBehaviour {
    public static ShopContoller Instance { get; private set; }

    public Global global;
    public PopUpController popUpController;

    [SerializeField] private Text activeShopText;
    [SerializeField] private Text activeShopUpgradeText;
    [SerializeField] private Text priceText;
    [SerializeField] private Text infoText;
    [SerializeField] private Text PowerText;
    [SerializeField] private Text percentual;
    [SerializeField] private Image img_fill;

    private string[] gpuArr = {
        "GF 256", "Radeon 9100", "Radeon X550", "GF 7300", "Radeon 2400", "GF 8800", "GF 9800",
        "GF GRX 460", "Radeon 6970", "Radeon 7730", "GF GTX 770", "GF TITAN", "GF 1080",
        "Vega 64", "GF 3090"
    };

    private string[] cpuArr =
        {"I 4004", "I 80376", "AX 386", "AM 5x86", "I Pentium 2", "I Pentium 3", "AM Athlon 64", "I Pentium D", "AM Athlon 2", "I5 750", "FX 9590", "I7 4770", "I7 6700", "RZ 1800", "I7 8700", "i7 9900", "RZ 5950"};

    private string[] ramArr = {
        "4 MB", "16 MB", "128 MB", "256 MB", "1 GB", "4 GB", "16 GB", "32 GB", "64 GB", "128 GB", "256 GB", "512 GB",
        "1 TB"
    };
    private string[] fanArr = {
        "1x 4cm", "1x 8 cm", "1x 12cm", "2x 8cm", "2x 12cm", "3x 12cm", "3x 16cm", "4x 12cm", "4x 16cm", "5x 12cm", "5x 16cm"
    };
    private string[] psuArr = {
        "30W", "50W", "130W", "200W", "250W", "300W", "400W", "500W", "600W", "700W", "800W", "1000W",
        "1250W"
    };
    private string[] hddArr = {
        "3 slot", "5 slot", "7 slot", "10 slot", "13 slot", "16 slot", "20 slot", "23 slot", "26 slot", "29 slot", "31 slot", "33 slot",
        "35 slot"
    };

    private string[] motherArr = {
        "level 2 supported", "level 4 supported", "level 6 supported", "level 8 supported", "Level 10 supported",
        "Level 12 supported", "everything supported"
    };


    private string[] wifiArr = {
        "100 kbps", "500 kbps", "1 mbps", "5 mbps", "25 mbps", "100 mbps", "250 mbps", "500 mbps", "750 mbps", "1 gbps"
    };



    private int[] gpuPrices =
        {2600, 3600, 5300, 7200, 9400, 10300, 13600, 15200, 20000, 25600, 37200, 53000, 67000, 83000, 100000};
    private int[] cpuPrices =
        {1200, 2300, 3500, 4750, 6600, 7800, 9200, 11200, 14500, 19900, 25000, 49000, 64000, 89000, 100000,120000,140000};

    private int[] ramPrcies =
        {800, 1600, 2300, 3600, 4500, 6000, 7300, 9000, 10900, 13200, 20000, 37000, 49000};

    private int[] fanPrices =
        {500, 1000, 1500, 2000, 2500, 3200, 4200, 5200, 6200, 8000, 10000};
    
    private int[] psuPrices =
        {800, 1600, 2300, 3600, 4500, 6000, 7300, 9000, 10900, 13200, 20000, 37000, 49000};
    private int[] hddPrices =
        {800, 1600, 2300, 3600, 4500, 6000, 7300, 9000, 10900, 13200, 20000, 37000, 49000};

    private int[] motherPrices =
        {1000, 5000, 10000, 15000, 20000, 25000, 30000};

    private int[] wifiPrices =
        {1000, 2000, 5000, 10000, 20000, 30000, 40000, 50000, 60000, 70000};


    private int cpuLevel = 0;
    private int gpuLevel = 0;
    private int ramLevel = 0;
    private int fanLevel = 0;
    private int psuLevel = 0;
    private int hddLevel = 0;
    private int motherLevel = 0;
    private int wifiLevel = 0;

    private float powerLevel;

    private int ActiveIndex = 0;

    private string[] Descriptions = {
        "Graphics cards are useful for mining digital coins",
        "The cpu is the brain of the computer",
        "The Ram is used for better speed while using multiple programs",
        "Fans cool down the pc giving better performance",
        "The psu is resposnible for giving the power to the pc",
        "HDD is used for storing more programs",
        "Better motherboard offers better code interpolation",
        "Wifi is used for better passive income performance"
    };

    private void Awake() {
        Instance = this;
    }

    private void Start() {
        global = Global.Instance;
        popUpController = PopUpController.Instance;
        UpdatePowerText();
    }

  

    public void OnClick_GPU() {
        if (gpuLevel == 15) { 
            activeShopText.text = "Graphics Card";
            activeShopUpgradeText.text = gpuArr[14];
            ActiveIndex = 0;
            priceText.text = "MAX";
            percentual.text = "100" + "%";
            img_fill.fillAmount = 1;
            return;
        }
      
        activeShopText.text = "Graphics Card";
        activeShopUpgradeText.text = gpuArr[gpuLevel];
        infoText.text = Descriptions[0];
        ActiveIndex = 0;
        priceText.text = "$" + gpuPrices[gpuLevel].ToString();
        
        percentual.text = (( 100f / (float) gpuArr.Length) *(gpuLevel)).ToString("F0") + "%";
        img_fill.fillAmount = (( (100f / (float) gpuArr.Length) *(gpuLevel))) / 100;
        
        UpdatePowerText();
    }

    public void OnClick_CPU() {
        
        if (cpuLevel == 17) { 
            activeShopText.text = "Central Processing Unit";
            activeShopUpgradeText.text = cpuArr[16];
            ActiveIndex = 1;
            priceText.text = "MAX";
            percentual.text = "100" + "%";
            img_fill.fillAmount = 1;
            return;
        }
        Debug.Log(cpuLevel);
        activeShopText.text = "Central Processing Unit";
        activeShopUpgradeText.text = cpuArr[cpuLevel];
        infoText.text = Descriptions[1];
        ActiveIndex = 1;
        priceText.text = "$" + cpuPrices[cpuLevel].ToString();
        
        percentual.text = (( 100f / (float) cpuArr.Length) *(cpuLevel)).ToString("F0") + "%";
        img_fill.fillAmount = (( (100f / (float) cpuArr.Length) *(cpuLevel))) / 100;
    }

    public void OnCLick_RAM() {
        
        if (ramLevel == 13) { 
            activeShopText.text = "Random Acess Memory";
            activeShopUpgradeText.text = ramArr[12];
            ActiveIndex = 2;
            priceText.text = "MAX";
            percentual.text = "100" + "%";
            img_fill.fillAmount = 1;
            return;
        }
        activeShopText.text = "Random Acess Memory";
        activeShopUpgradeText.text = ramArr[ramLevel];
        infoText.text = Descriptions[2];
        ActiveIndex = 2;

        percentual.text = (( 100f / (float) ramArr.Length) *(ramLevel)).ToString("F0") + "%";
        img_fill.fillAmount = (( (100f / (float) ramArr.Length) *(ramLevel))) / 100;
    }

    public void OnCLick_FAN() {
        
        if (fanLevel == 11) { 
            activeShopText.text = "Colling System";
            activeShopUpgradeText.text = fanArr[10];
            ActiveIndex = 3;
            priceText.text = "MAX";
            percentual.text = "100" + "%";
            img_fill.fillAmount = 1;
            return;
        }
        activeShopText.text = "Colling System";
        activeShopUpgradeText.text = fanArr[fanLevel];
        infoText.text = Descriptions[3];
        ActiveIndex = 3;

        percentual.text = (( 100f / (float) fanArr.Length) *(fanLevel)).ToString("F0") + "%";
        img_fill.fillAmount = (( (100f / (float) fanArr.Length) *(fanLevel))) / 100;
    }

    public void OnCLick_PSU() {
        
        if (psuLevel == 13) { 
            activeShopText.text = "Power Supply";
            activeShopUpgradeText.text = psuArr[12];
            ActiveIndex = 4;
            priceText.text = "MAX";
            percentual.text = "100" + "%";
            img_fill.fillAmount = 1;
            return;
        }
        activeShopText.text = "Power Supply";
        activeShopUpgradeText.text = psuArr[psuLevel];
        infoText.text = Descriptions[4];
        ActiveIndex = 4;
        
        percentual.text = (( 100f / (float) psuArr.Length) *(psuLevel)).ToString("F0") + "%";
        img_fill.fillAmount = (( (100f / (float) psuArr.Length) *(psuLevel))) / 100;
    }

    public void OnCLick_HDD() {
        
        if (hddLevel == 13) { 
            activeShopText.text = "Hard Drive";
            activeShopUpgradeText.text = hddArr[12];
            ActiveIndex = 5;
            priceText.text = "MAX";
            percentual.text = "100" + "%";
            img_fill.fillAmount = 1;
            return;
        }
        activeShopText.text = "Hard Drive";
        activeShopUpgradeText.text = hddArr[hddLevel];
        infoText.text = Descriptions[5];
        ActiveIndex = 5;

        percentual.text = (( 100f / (float) hddArr.Length) *(hddLevel)).ToString("F0") + "%";
        img_fill.fillAmount = (( (100f / (float) hddArr.Length) *(hddLevel))) / 100;
    }

    public void OnCLick_MOTHER() {
        
        if (motherLevel == 7) { 
            activeShopText.text = "MotherBoard";
            activeShopUpgradeText.text = motherArr[6];
            ActiveIndex = 6;
            priceText.text = "MAX";
            percentual.text = "100" + "%";
            img_fill.fillAmount = 1;
            return;
        }
        activeShopText.text = "MotherBoard";
        activeShopUpgradeText.text = motherArr[motherLevel];
        infoText.text = Descriptions[6];
        ActiveIndex = 6;

        percentual.text = (( 100f / (float) motherArr.Length) *(motherLevel)).ToString("F0") + "%";
        img_fill.fillAmount = (( (100f / (float) motherArr.Length) *(motherLevel))) / 100;
    }

    public void OnCLick_WIFI() {
        
        if (wifiLevel == 10) { 
            activeShopText.text = "WIFI";
            activeShopUpgradeText.text = wifiArr[9];
            ActiveIndex = 7;
            priceText.text = "MAX";
            percentual.text = "100" + "%";
            img_fill.fillAmount = 1;
            return;
        }
        activeShopText.text = "WIFI";
        activeShopUpgradeText.text = wifiArr[wifiLevel];
        infoText.text = Descriptions[7];
        ActiveIndex = 7;

        percentual.text = (( 100f / (float) wifiArr.Length) *(wifiLevel)).ToString("F0") + "%";
        img_fill.fillAmount = (( (100f / (float) wifiArr.Length) *(wifiLevel))) / 100;
    }


    public void UpdatePowerText() {
        powerLevel = (cpuLevel / 3f) * gpuLevel * (ramLevel / 10f) * (fanLevel / 3f) * (psuLevel / 10f) *
                     (hddLevel / 50f) * (motherLevel / 20) * (wifiLevel * 1.3f);
        PowerText.text = "POWER :" + powerLevel.ToString("F2");
    }

    public Text GetActiveShopText() {
        return activeShopText;
    }

    public Text GetActiveShopUpgradeText() {
        return activeShopUpgradeText;
    }

    public Text GetInfoText() {
        return infoText;
    }

    public int GetIndex() {
        return ActiveIndex;
    }

    public void Upgrade() {
        int index = GetIndex();
        int balance = global.GetBalance();
        
        switch (index) {
            case 0 :
                if (gpuLevel < 15 && balance >= gpuPrices[gpuLevel]) {
                    global.UpdateBalance(-gpuPrices[gpuLevel]);
                        gpuLevel++;
                        OnClick_GPU();
                }
                else if (gpuLevel == 15) {
                    popUpController.UsePopUp_AlreadyAtMaxLevel();
                }
                else {
                    popUpController.UsePopUp_NotEnoughMoney();
                }
                break;
            case 1:
                if (cpuLevel < 17 && balance >= cpuPrices[cpuLevel]) {
                    global.UpdateBalance(-cpuPrices[cpuLevel]);
                    cpuLevel++;
                    OnClick_CPU();
                }
                else if (cpuLevel == 17) {
                    popUpController.UsePopUp_AlreadyAtMaxLevel();
                }
                else {
                    popUpController.UsePopUp_NotEnoughMoney();
                }
                break;
            case 2:
                if (ramLevel < 13 && balance >= ramPrcies[ramLevel]) {
                    global.UpdateBalance(-ramPrcies[ramLevel]);
                    ramLevel++;
                    OnCLick_RAM();
                }
                else if (ramLevel == 13) {
                    popUpController.UsePopUp_AlreadyAtMaxLevel();
                }
                else {
                    popUpController.UsePopUp_NotEnoughMoney();
                }
                break;
            case 3:
                if (fanLevel < 11 && balance >= fanPrices[fanLevel]) {
                    global.UpdateBalance(-fanPrices[fanLevel]);
                    fanLevel++;
                    OnCLick_FAN();
                }
                else if (fanLevel == 11) {
                    popUpController.UsePopUp_AlreadyAtMaxLevel();
                }
                else {
                    popUpController.UsePopUp_NotEnoughMoney();
                }
                break;
            case 4:
                if (psuLevel < 13 && balance >= psuPrices[psuLevel]) {
                    global.UpdateBalance(-psuPrices[psuLevel]);
                    psuLevel++;
                    OnCLick_PSU();
                }
                else if (psuLevel == 13) {
                    popUpController.UsePopUp_AlreadyAtMaxLevel();
                }
                else {
                    popUpController.UsePopUp_NotEnoughMoney();
                }
                break;
            case 5:
                if (hddLevel < 13 && balance >= hddPrices[hddLevel]) {
                    global.UpdateBalance(-hddPrices[hddLevel]);
                    hddLevel++;
                    OnCLick_HDD();
                }
                else if (hddLevel == 13) {
                    popUpController.UsePopUp_AlreadyAtMaxLevel();
                }
                else {
                    popUpController.UsePopUp_NotEnoughMoney();
                }
                break;
            case 6:
                if (motherLevel < 7 && balance >= motherPrices[motherLevel]) {
                    global.UpdateBalance(-motherPrices[motherLevel]);
                    motherLevel++;
                   OnCLick_MOTHER();
                }
                else if (motherLevel == 7) {
                    popUpController.UsePopUp_AlreadyAtMaxLevel();
                }
                else {
                    popUpController.UsePopUp_NotEnoughMoney();
                }
                break;
            case 7:
                if (wifiLevel < 10 && balance >= wifiPrices[wifiLevel]) {
                    global.UpdateBalance(-wifiPrices[wifiLevel]);
                    wifiLevel++;
                    OnCLick_WIFI();
                }
                else if (wifiLevel == 10) {
                    popUpController.UsePopUp_AlreadyAtMaxLevel();
                }
                else {
                    popUpController.UsePopUp_NotEnoughMoney();
                }
                break;
        }
    }
    
    public int GetCpuLevel() {
        return cpuLevel;
    }
    public int GetGpuLevel() {
        return gpuLevel;
    }
    public int GetRamLevel() {
        return ramLevel;
    }
    public int GetFanLevel() {
        return fanLevel;
    }
    public int GetPsuLevel() {
        return psuLevel;
    }
    public int GetHddLevel() {
        return hddLevel;
    }
    public int GetMotherLevel() {
        return motherLevel;
    }
    public int GetWifiLevel() {
        return wifiLevel;
    }

    public void setCpuLevel(int level) {
        cpuLevel = level;
    }
    public void setGpuLevel(int level) {
        gpuLevel = level;
    }
    
    public void setRamLevel(int level) {
        ramLevel = level;
    }
    public void setCFanLevel(int level) {
        fanLevel = level;
    }
    public void setPsuLevel(int level) {
        psuLevel = level;
    }
    public void setHddLevel(int level) {
        hddLevel = level;
    }
    public void setMotherLevel(int level) {
        motherLevel = level;
    }
    public void setWifiLevel(int level) {
        wifiLevel = level;
    }
}