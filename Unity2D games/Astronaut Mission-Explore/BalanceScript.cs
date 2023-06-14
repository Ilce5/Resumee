using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class BalanceScript : MonoBehaviour
{
    public static bool finished = false;

    public static int currentFuel = 400;
    public static float rocketCurrent;
    public static int balance = 0;
    public static bool bhUnlocked = false;
    public static int playAnimation = 0;

    public static bool musicAudio = true;
    public static bool sfxMusic = true;
    public static float musicVolume = 0.225f;

    //Engine
    public static int ePrice = 550;
    public static float elvl;
    public static float consumption = 16;

    public static int cPrice = 550;
    public static float clvl;
    public static float cooling = 0.5f;

    public static int pPrice = 550;
    public static float plvl;
    public static float speedFly = 650f;

    public static int dPrice = 250;
    public static float dlvl;
    public static float maxDamage = 0.15f;
    public static float minDamage = 0.04f;

    public static int bPrice = 250;
    public static float blvl;
    public static float boostSpeed = 750f;

    //Reward
    public static float reward = 1f;
    public static int rewardLvl;
    public static int rewardPrice = 500;

    //Taps
    public static int rfPrice = 200;
    public static int rfLvl = 1;
    public static int rpPrice = 100;
    public static int rpLvl = 1;
    public static float rpClick = 0.007f;
    public static float rpBonus = 0.001f;

    //Fuel Capacity
    public static int globalTank = 400;
    public static int rocketTank = 60;

    //Repair
    public static float air = 1f;
    public static float cooler = 1f;
    public static float compressor = 1f;
    public static float turbine = 1f;
    public static float engine = 1f;
    public static float ramjet = 1f;
    public static float nozzle = 1f;

    //Achivements
    public static float topSpeed;
    public static int unlockedPlanets = 1;
    public static int purchasedRockets = 1;
    public static int upgradedEngine;
    public static int repairedClicks;
    public static int achivement1;
    public static int achivement2;
    public static int achivement3;
    public static int achivement4;
    public static int achivement5;
    public static float totalAchivement;
    public static float profileLevel;
    public static float currentAchivement;

    public static bool checkTheme1;
    public static bool checkTheme2;
    public static bool checkTheme3;
    public static bool checkTheme4;
    public static bool checkTheme5;

    //rockets
    public static bool rcheck2 = false;
    public static bool rcheck3 = false;
    public static bool rcheck4 = false;
    public static bool rcheck5 = false;
    public static bool rcheck6 = false;
    public static bool rcheck7 = false;
    public static bool rcheck8 = false;
    public static bool rcheck9 = false;
    public static bool rcheck10 = false;

    public static bool rEngine1 = true;
    public static bool rEngine2 = false;
    public static bool rEngine3 = false;
    public static bool rEngine4 = false;
    public static bool rEngine5 = false;
    public static bool rEngine6 = false;
    public static bool rEngine7 = false;
    public static bool rEngine8 = false;
    public static bool rEngine9 = false;
    public static bool rEngine10 = false;
    ////////////////////////////////////////////////////////////////////////////////STOp


    public bool finished1 = finished;

    public int currentFuel1 = currentFuel;
    public float rocketCurrent1 = rocketCurrent;
    public int balance1 = balance;
    public bool bhUnlocked1 = bhUnlocked;
    public int playAnimation1 = playAnimation;

    public bool musicAudio1 = musicAudio;
    public bool sfxMusic1 = sfxMusic;
    public float musicVolume1 = musicVolume;

    //Engine
    public int ePrice1 = ePrice;
    public float elvl1 = elvl;
    public float consumption1 = consumption;

    public int cPrice1 = cPrice;
    public float clvl1 = clvl;
    public float cooling1 = cooling;

    public int pPrice1 = pPrice;
    public float plvl1 = plvl;
    public float speedFly1 = speedFly;

    public int dPrice1 = dPrice;
    public float dlvl1 = dlvl;
    public float maxDamage1 = maxDamage;
    public float minDamage1 = minDamage;

    public int bPrice1 = bPrice;
    public float blvl1 = blvl;
    public float boostSpeed1 = boostSpeed;

    //Reward
    public float reward1 = reward;
    public int rewardLvl1 = rewardLvl;
    public int rewardPrice1 = rewardPrice;

    //Taps
    public int rfPrice1 = rfPrice;
    public int rfLvl1 = rfLvl;
    public int rpPrice1 = rpPrice;
    public int rpLvl1 = rpLvl;
    public float rpClick1 = rpClick;
    public float rpBonus1 = rpBonus;

    //Fuel Capacity
    public int globalTank1 = globalTank;
    public int rocketTank1 = rocketTank;

    //Repair
    public float air1 = air;
    public float cooler1 = cooler;
    public float compressor1 = compressor;
    public float turbine1 = turbine;
    public float engine1 = engine;
    public float ramjet1 = ramjet;
    public float nozzle1 = nozzle;

    //Achivements
    public float topSpeed1 = topSpeed;
    public int unlockedPlanets1 = unlockedPlanets;
    public int purchasedRockets1 = purchasedRockets;
    public int upgradedEngine1 = upgradedEngine;
    public int repairedClicks1 = repairedClicks;
    public int achivement11 = achivement1;
    public int achivement21 = achivement2;
    public int achivement31 = achivement3;
    public int achivement41 = achivement4;
    public int achivement51 = achivement5;
    public float totalAchivement1 = totalAchivement;
    public float profileLevel1 = profileLevel;
    public float currentAchivement1 = currentAchivement;

    public bool checkTheme11 = checkTheme1;
    public bool checkTheme21 = checkTheme2;
    public bool checkTheme31 = checkTheme3;
    public bool checkTheme41 = checkTheme4;
    public bool checkTheme51 = checkTheme5;

    //rocket
    public bool rcheck21 = rcheck2;
    public bool rcheck31 = rcheck3;
    public bool rcheck41 = rcheck4;
    public bool rcheck51 = rcheck5;
    public bool rcheck61 = rcheck6;
    public bool rcheck71 = rcheck7;
    public bool rcheck81 = rcheck8;
    public bool rcheck91 = rcheck9;
    public bool rcheck101 = rcheck10;

    public bool rEngine11 = false;
    public bool rEngine21 = false;
    public bool rEngine31 = false;
    public bool rEngine41 = false;
    public bool rEngine51 = false;
    public bool rEngine61 = false;
    public bool rEngine71 = false;
    public bool rEngine81 = false;
    public bool rEngine91 = false;
    public bool rEngine101 = false;

    public void Save()
    {
        finished1 = finished;

        currentFuel1 = currentFuel;
        rocketCurrent1 = rocketCurrent;
        balance1 = balance;
        bhUnlocked1 = bhUnlocked;
        playAnimation1 = playAnimation;

        musicAudio1 = musicAudio;
        sfxMusic1 = sfxMusic;
        musicVolume1 = musicVolume;

        //Engine
        ePrice1 = ePrice;
        elvl1 = elvl;
        consumption1 = consumption;

        cPrice1 = cPrice;
        clvl1 = clvl;
        cooling1 = cooling;

        pPrice1 = pPrice;
        plvl1 = plvl;
        speedFly1 = speedFly;

        dPrice1 = dPrice;
        dlvl1 = dlvl;
        maxDamage1 = maxDamage;
        minDamage1 = minDamage;

        bPrice1 = bPrice;
        blvl1 = blvl;
        boostSpeed1 = boostSpeed;

        //Reward
        reward1 = reward;
        rewardLvl1 = rewardLvl;
        rewardPrice1 = rewardPrice;

        //Taps
        rfPrice1 = rfPrice;
        rfLvl1 = rfLvl;
        rpPrice1 = rpPrice;
        rpLvl1 = rpLvl;
        rpClick1 = rpClick;
        rpBonus1 = rpBonus;

        //Fuel Capacity
        globalTank1 = globalTank;
        rocketTank1 = rocketTank;

        //Repair
        air1 = air;
        cooler1 = cooler;
        compressor1 = compressor;
        turbine1 = turbine;
        engine1 = engine;
        ramjet1 = ramjet;
        nozzle1 = nozzle;

        //Achivements
        topSpeed1 = topSpeed;
        unlockedPlanets1 = unlockedPlanets;
        purchasedRockets1 = purchasedRockets;
        upgradedEngine1 = upgradedEngine;
        repairedClicks1 = repairedClicks;
        achivement11 = achivement1;
        achivement21 = achivement2;
        achivement31 = achivement3;
        achivement41 = achivement4;
        achivement51 = achivement5;
        totalAchivement1 = totalAchivement;
        profileLevel1 = profileLevel;
        currentAchivement1 = currentAchivement;

        checkTheme11 = checkTheme1;
        checkTheme21 = checkTheme2;
        checkTheme31 = checkTheme3;
        checkTheme41 = checkTheme4;
        checkTheme51 = checkTheme5;
        rcheck21 = rcheck2;
        rcheck31 = rcheck3;
        rcheck41 = rcheck4;
        rcheck51 = rcheck5;
        rcheck61 = rcheck6;
        rcheck71 = rcheck7;
        rcheck81 = rcheck8;
        rcheck91 = rcheck9;
        rcheck101 = rcheck10;

        rEngine11 = rEngine1;
        rEngine21 = rEngine2;
        rEngine31 = rEngine3;
        rEngine41 = rEngine4;
        rEngine51 = rEngine5;
        rEngine61 = rEngine6;
        rEngine71 = rEngine7;
        rEngine81 = rEngine8;
        rEngine91 = rEngine9;
        rEngine101 = rEngine10;

    SaveSystem.SavePlayer(this);
    }

    public void Load()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        finished = data.finished;
        currentFuel = data.currentFuel;
        rocketCurrent = data.rocketCurrent;
        balance = data.balance;
        bhUnlocked = data.bhUnlocked;
        playAnimation = data.playAnimation;
        musicAudio = data.musicAudio;
        sfxMusic = data.sfxMusic;
        musicVolume = data.musicVolume;
        ePrice = data.ePrice;
        elvl = data.elvl;
        consumption = data.consumption;
        cPrice = data.cPrice;
        clvl = data.clvl;
        cooling = data.cooling;
        pPrice = data.pPrice;
        plvl = data.plvl;
        speedFly = data.speedFly;
        dPrice = data.dPrice;
        dlvl = data.dlvl;
        maxDamage = data.maxDamage;
        minDamage = data.minDamage;
        bPrice = data.bPrice;
        blvl = data.blvl;
        boostSpeed = data.boostSpeed;
        reward = data.reward;
        rewardLvl = data.rewardLvl;
        rewardPrice = data.rewardPrice;
        rfPrice = data.rfPrice;
        rfLvl = data.rfLvl;
        rpPrice = data.rpPrice;
        rpLvl = data.rpLvl;
        rpClick = data.rpClick;
        rpBonus = data.rpBonus;
        globalTank = data.globalTank;
        rocketTank = data.rocketTank;
        air = data.air;
        cooler = data.cooler;
        compressor = data.compressor;
        turbine = data.turbine;
        engine = data.engine;
        ramjet = data.ramjet;
        nozzle = data.nozzle;
        topSpeed = data.topSpeed;
        unlockedPlanets = data.unlockedPlanets;
        purchasedRockets = data.purchasedRockets;
        upgradedEngine = data.upgradedEngine;
        repairedClicks = data.repairedClicks;
        achivement1 = data.achivement1;
        achivement2 = data.achivement2;
        achivement3 = data.achivement3;
        achivement4 = data.achivement4;
        achivement5 = data.achivement5;
        totalAchivement = data.totalAchivement;
        profileLevel = data.profileLevel;
        currentAchivement = data.currentAchivement;
        checkTheme1 = data.checkTheme1;
        checkTheme2 = data.checkTheme2;
        checkTheme3 = data.checkTheme3;
        checkTheme4 = data.checkTheme4;
        checkTheme5 = data.checkTheme5;
        rcheck2 = data.rcheck2;
        rcheck3 = data.rcheck3;
        rcheck4 = data.rcheck4;
        rcheck5 = data.rcheck5;
        rcheck6 = data.rcheck6;
        rcheck7 = data.rcheck7;
        rcheck8 = data.rcheck8;
        rcheck9 = data.rcheck9;
        rcheck10 = data.rcheck10;
        rEngine1 = data.rEngine1;
        rEngine2 = data.rEngine2;
        rEngine3 = data.rEngine3;
        rEngine4 = data.rEngine4;
        rEngine5 = data.rEngine5;
        rEngine6 = data.rEngine6;
        rEngine7 = data.rEngine7;
        rEngine8 = data.rEngine8;
        rEngine9 = data.rEngine9;
        rEngine10 = data.rEngine10;
    }
        public void ResetIt()
    {
        finished = false;
        currentFuel = 400;
        rocketCurrent = 0;
        balance = 0;
        bhUnlocked = false;
        playAnimation = 0;
        musicAudio = true;
        sfxMusic = true;
        musicVolume = 0.225f;
        ePrice = 550;
        elvl = 0;
        consumption = 16;
        cPrice = 550;
        clvl = 0;
        cooling = 0.5f;
        pPrice = 550;
        plvl = 0;
        speedFly = 650f;
        dPrice = 250;
        dlvl = 0;
        maxDamage = 0.15f;
        minDamage = 0.04f;
        bPrice = 250;
        blvl = 0;
        boostSpeed = 750f;
        reward = 1f;
        rewardLvl = 0;
        rewardPrice = 500;
        rfPrice = 200;
        rfLvl = 1;
        rpPrice = 100;
        rpLvl = 1;
        rpClick = 0.007f;
        rpBonus = 0.001f;
        globalTank = 400;
        rocketTank = 60;
        air = 1f;
        cooler = 1f;
        compressor = 1f;
        turbine = 1f;
        engine = 1f;
        ramjet = 1f;
        nozzle = 1f;
        topSpeed = 0;
        unlockedPlanets = 1;
        purchasedRockets = 1;
        upgradedEngine = 0;
        repairedClicks = 0;
        achivement1 = 0;
        achivement2 = 0;
        achivement3 = 0;
        achivement4 = 0;
        achivement5 = 0;
        totalAchivement = 0;
        profileLevel = 0;
        currentAchivement = 0;
        checkTheme1 = false;
        checkTheme2 = false;
        checkTheme3 = false;
        checkTheme4 = false;
        checkTheme5 = false;
        rcheck2 = false;
        rcheck3 = false;
        rcheck4 = false;
        rcheck5 = false;
        rcheck6 = false;
        rcheck7 = false;
        rcheck8 = false;
        rcheck9 = false;
        rcheck10 = false;
    }
}
