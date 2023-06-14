using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public bool finished;

    public int currentFuel;
    public float rocketCurrent;
    public int balance;

    public bool bhUnlocked;

    public int playAnimation;

    public bool musicAudio = true;
    public bool sfxMusic = true;
    public float musicVolume;

    //Engine
    public int ePrice;
    public float elvl;
    public float consumption;

    public int cPrice;
    public float clvl;
    public float cooling;

    public int pPrice;
    public float plvl;
    public float speedFly;

    public int dPrice;
    public float dlvl;
    public float maxDamage;
    public float minDamage;

    public int bPrice;
    public float blvl;
    public float boostSpeed;

    //Reward
    public float reward;
    public int rewardLvl;
    public int rewardPrice;

    //Taps
    public int rfPrice;
    public int rfLvl;
    public int rpPrice;
    public int rpLvl;
    public float rpClick;
    public float rpBonus;

    //Fuel Capacity
    public int globalTank;
    public int rocketTank;

    //Repair
    public float air;
    public float cooler;
    public float compressor;
    public float turbine;
    public float engine;
    public float ramjet;
    public float nozzle;

    //Achivements
    public float topSpeed;
    public int unlockedPlanets;
    public int purchasedRockets;
    public int upgradedEngine;
    public int repairedClicks;
    public int achivement1;
    public int achivement2;
    public int achivement3;
    public int achivement4;
    public int achivement5;
    public float totalAchivement;
    public float profileLevel;
    public float currentAchivement;

    public bool checkTheme1;
    public bool checkTheme2;
    public bool checkTheme3;
    public bool checkTheme4;
    public bool checkTheme5;

    public bool rcheck2 = false;
    public bool rcheck3 = false;
    public bool rcheck4 = false;
    public bool rcheck5 = false;
    public bool rcheck6 = false;
    public bool rcheck7 = false;
    public bool rcheck8 = false;
    public bool rcheck9 = false;
    public bool rcheck10 = false;

    public bool rEngine1 = false;
    public bool rEngine2 = false;
    public bool rEngine3 = false;
    public bool rEngine4 = false;
    public bool rEngine5 = false;
    public bool rEngine6 = false;
    public bool rEngine7 = false;
    public bool rEngine8 = false;
    public bool rEngine9 = false;
    public bool rEngine10 = false;

    public PlayerData (BalanceScript balanceScript)
    {
        finished = balanceScript.finished1;
        currentFuel = balanceScript.currentFuel1;
        rocketCurrent = balanceScript.rocketCurrent1;
        balance = balanceScript.balance1;
        bhUnlocked = balanceScript.bhUnlocked1;
        playAnimation = balanceScript.playAnimation1;
        musicAudio = balanceScript.musicAudio1;
        sfxMusic = balanceScript.sfxMusic1;
        musicVolume = balanceScript.musicVolume1;
        ePrice = balanceScript.ePrice1;
        elvl = balanceScript.elvl1;
        consumption = balanceScript.consumption1;
        cPrice = balanceScript.cPrice1;
        clvl = balanceScript.clvl1;
        cooling = balanceScript.cooling1;
        pPrice = balanceScript.pPrice1;
        plvl = balanceScript.plvl1;
        speedFly = balanceScript.speedFly1;
        dPrice = balanceScript.dPrice1;
        dlvl = balanceScript.dlvl1;
        maxDamage = balanceScript.maxDamage1;
        minDamage = balanceScript.minDamage1;
        bPrice = balanceScript.bPrice1;
        blvl = balanceScript.blvl1;
        boostSpeed = balanceScript.boostSpeed1;
        reward = balanceScript.reward1;
        rewardLvl = balanceScript.rewardLvl1;
        rewardPrice = balanceScript.rewardPrice1;
        rfPrice = balanceScript.rfPrice1;
        rfLvl = balanceScript.rfLvl1;
        rpPrice = balanceScript.rpPrice1;
        rpLvl = balanceScript.rpLvl1;
        rpClick = balanceScript.rpClick1;
        rpBonus = balanceScript.rpBonus1;
        globalTank = balanceScript.globalTank1;
        rocketTank = balanceScript.rocketTank1;
        air = balanceScript.air1;
        cooler = balanceScript.cooler1;
        compressor = balanceScript.compressor1;
        turbine = balanceScript.turbine1;
        engine = balanceScript.engine1;
        ramjet = balanceScript.ramjet1;
        nozzle = balanceScript.nozzle1;
        topSpeed = balanceScript.topSpeed1;
        unlockedPlanets = balanceScript.unlockedPlanets1;
        purchasedRockets = balanceScript.purchasedRockets1;
        upgradedEngine = balanceScript.upgradedEngine1;
        repairedClicks = balanceScript.repairedClicks1;
        achivement1 = balanceScript.achivement11;
        achivement2 = balanceScript.achivement21;
        achivement3 = balanceScript.achivement31;
        achivement4 = balanceScript.achivement41;
        achivement5 = balanceScript.achivement51;
        totalAchivement = balanceScript.totalAchivement1;
        profileLevel = balanceScript.profileLevel1;
        currentAchivement = balanceScript.currentAchivement1;
        checkTheme1 = balanceScript.checkTheme11;
        checkTheme2 = balanceScript.checkTheme21;
        checkTheme3 = balanceScript.checkTheme31;
        checkTheme4 = balanceScript.checkTheme41;
        checkTheme5 = balanceScript.checkTheme51;
        rcheck2 = balanceScript.rcheck21;
        rcheck3 = balanceScript.rcheck31;
        rcheck4 = balanceScript.rcheck41;
        rcheck5 = balanceScript.rcheck51;
        rcheck6 = balanceScript.rcheck61;
        rcheck7 = balanceScript.rcheck71;
        rcheck8 = balanceScript.rcheck81;
        rcheck9 = balanceScript.rcheck91;
        rcheck10 = balanceScript.rcheck101;
        rEngine1 = balanceScript.rEngine11;
        rEngine2 = balanceScript.rEngine21;
        rEngine3 = balanceScript.rEngine31;
        rEngine4 = balanceScript.rEngine41;
        rEngine5 = balanceScript.rEngine51;
        rEngine6 = balanceScript.rEngine61;
        rEngine7 = balanceScript.rEngine71;
        rEngine8 = balanceScript.rEngine81;
        rEngine9 = balanceScript.rEngine91;
        rEngine10 = balanceScript.rEngine101;
    }
}
