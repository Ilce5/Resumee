using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RepairScript : MonoBehaviour
{
    public GameObject air;
    public GameObject cooler;
    public GameObject compressor;
    public GameObject turbine;
    public GameObject engine;
    public GameObject ramjet;
    public GameObject nozzle;

    public Image airI;
    public Image coolerI;
    public Image compressorI;
    public Image turbineI;
    public Image engineI;
    public Image ramjetI;
    public Image nozzleI;

    private int clicks;
    public ParticleSystem part1;
    public Image repairButton;

    public Sprite lvl2;
    public Sprite lvl3;
    public Sprite lvl4;
    public Sprite lvl5;

    public ParticleSystem airSmoke;
    public ParticleSystem coolerSmoke;
    public ParticleSystem compressorSmoke;
    public ParticleSystem turbineSmoke;
    public ParticleSystem engineSmoke;
    public ParticleSystem ramjetSmoke;
    public ParticleSystem nozzleSmoke;
    private bool checkSmoke = false;

    public Text repairText;
    void Update()
    {
        if (checkSmoke == false)
        {
            if (BalanceScript.air < 0.5f)
            {
                airSmoke.Play();
            }
            if (BalanceScript.cooler < 0.5f)
            {
                coolerSmoke.Play();
            }
            if (BalanceScript.compressor < 0.5f)
            {
                compressorSmoke.Play();
            }
            if (BalanceScript.turbine < 0.5f)
            {
                turbineSmoke.Play();
            }
            if (BalanceScript.engine < 0.5f)
            {
                engineSmoke.Play();
            }
            if (BalanceScript.ramjet < 0.5f)
            {
                ramjetSmoke.Play();
            }
            if (BalanceScript.nozzle < 0.5f)
            {
                nozzleSmoke.Play();
            }
            checkSmoke = true;
        }
        if (BalanceScript.repairedClicks < 200)
        {
            repairText.text = "For 50%" + "\n" + "repair";
        }
        else if (BalanceScript.repairedClicks < 500)
        {
            repairText.text = "For 60%" + "\n" + "repair";
        }
        else if (BalanceScript.repairedClicks < 1500)
        {
            repairText.text = "For 70%" + "\n" + "repair";
        }
        else
        {
            repairText.text = "For 80%" + "\n" + "repair";
        }
    }
    // Update is called once per frame
    void Start()
    {
        UpdateImage();
        if (BalanceScript.repairedClicks >= 200)
        {
            repairButton.sprite = lvl2;
            if (BalanceScript.repairedClicks >= 500)
            {
                repairButton.sprite = lvl3;
                if (BalanceScript.repairedClicks >= 900)
                {
                    repairButton.sprite = lvl4;
                    if (BalanceScript.repairedClicks >= 1500)
                    {
                        repairButton.sprite = lvl5;
                    }
                }
            }
        }
    }
    public void UpdateImage()
    {
        airI.fillAmount = BalanceScript.air;
        coolerI.fillAmount = BalanceScript.cooler;
        compressorI.fillAmount = BalanceScript.compressor;
        turbineI.fillAmount = BalanceScript.turbine;
        engineI.fillAmount = BalanceScript.engine;
        ramjetI.fillAmount = BalanceScript.ramjet;
        nozzleI.fillAmount = BalanceScript.nozzle;
        Repairing();
    }

    public void Repairing()
    {
        if (clicks > 99)
        {
            part1.Play();
        }
        if (air.activeSelf)
        {
            if (BalanceScript.air < 1f)
            {
                BalanceScript.repairedClicks++;
                BalanceScript.air += BalanceScript.rpClick;
                clicks++;
                airI.fillAmount = BalanceScript.air;
            }
        }
        else if (cooler.activeSelf)
        {
            if (BalanceScript.cooler < 1f)
            {
                BalanceScript.repairedClicks++;
                BalanceScript.cooler += BalanceScript.rpClick;
                clicks++;
                coolerI.fillAmount = BalanceScript.cooler;
            }
        }
        else if (compressor.activeSelf)
        {
            if (BalanceScript.compressor < 1f)
            {
                BalanceScript.repairedClicks++;
                BalanceScript.compressor += BalanceScript.rpClick;
                clicks++;
                compressorI.fillAmount = BalanceScript.compressor;
            }
        }
        else if (turbine.activeSelf)
        {
            if (BalanceScript.turbine < 1f)
            {
                BalanceScript.repairedClicks++;
                BalanceScript.turbine += BalanceScript.rpClick;
                clicks++;
                turbineI.fillAmount = BalanceScript.turbine;
            }
        }
        else if (engine.activeSelf)
        {
            if (BalanceScript.engine < 1f)
            {
                BalanceScript.repairedClicks++;
                BalanceScript.engine += BalanceScript.rpClick;
                clicks++;
                engineI.fillAmount = BalanceScript.engine;
            }
        }
        else if (ramjet.activeSelf)
        {
            if (BalanceScript.ramjet < 1f)
            {
                BalanceScript.repairedClicks++;
                BalanceScript.ramjet += BalanceScript.rpClick;
                clicks++;
                ramjetI.fillAmount = BalanceScript.ramjet;
            }
        }
        else if (nozzle.activeSelf)
        {
            if (BalanceScript.nozzle < 1f)
            {
                BalanceScript.repairedClicks++;
                BalanceScript.nozzle += BalanceScript.rpClick;
                clicks++;
                nozzleI.fillAmount = BalanceScript.nozzle;
            }
        }
        if (BalanceScript.repairedClicks >= 200)
        {
            repairButton.sprite = lvl2;
            if (BalanceScript.repairedClicks >= 500)
            {
                repairButton.sprite = lvl3;
                if(BalanceScript.repairedClicks >= 900)
                {
                    repairButton.sprite = lvl4;
                    if(BalanceScript.repairedClicks >= 1500)
                    {
                        repairButton.sprite = lvl5;
                    }
                }
            }
        }
        if (BalanceScript.air > 0.5f)
        {
            airSmoke.Stop();
        }
        if (BalanceScript.cooler > 0.5f)
        {
            coolerSmoke.Stop();
        }
        if (BalanceScript.compressor > 0.5f)
        {
            compressorSmoke.Stop();
        }
        if (BalanceScript.turbine > 0.5f)
        {
            turbineSmoke.Stop();
        }
        if (BalanceScript.engine > 0.5f)
        {
            engineSmoke.Stop();
        }
        if (BalanceScript.ramjet > 0.5f)
        {
            ramjetSmoke.Stop();
        }
        if (BalanceScript.nozzle > 0.5f)
        {
            nozzleSmoke.Stop();
        }
    }
    public void turnOff()
    {
        air.SetActive(false);
        cooler.SetActive(false);
        compressor.SetActive(false);
        turbine.SetActive(false);
        engine.SetActive(false);
        ramjet.SetActive(false);
        nozzle.SetActive(false);
        clicks = 0;
        part1.Stop();
    }
    public void checkMarkSmoke()
    {
        checkSmoke = false;
    }
}
