using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dissolve : MonoBehaviour
{
    Material material;
    bool isDissolving = false;
    float fade = 0f;
    public Animator noFuel;
    public GameObject playCanvas;
    public GameObject customCanvas;
    private float damage;
    public Text popUp;
    public GameObject refuelButton;
    public GameObject repairButton;
    public GameObject playButton;
    public GameObject scrollOff;
    public GameObject exitOff;
    public GameObject blockImage;
    public GameObject noFuelObject;

    void Start()
    {
        material = GetComponent<Image>().material;
    }

    void Update()
    {
        if (isDissolving)
        {
            if (fade < 1f)
            {
                fade += Time.deltaTime;
            }
        }
        else if (!isDissolving)
        {
            if (fade > 0f)
            {
                fade -= Time.deltaTime;
            }
            else
            {
                blockImage.SetActive(false);
            }
        }
        material.SetFloat("_Fade", fade);
    }
    public void TurnDissolving()
    {
        if (!isDissolving)
            {
                isDissolving = true;
            ChosePlanet.particlesDisable = true;
            }
            else if (isDissolving)
            {
                isDissolving = false;
            ChosePlanet.particlesDisable = false;
            blockImage.SetActive(true);
        }

    }
    public void PlayClick()
    {
        if (BalanceScript.currentFuel >= BalanceScript.rocketTank)
        {
            if(BalanceScript.air >= 0.25f && BalanceScript.cooler >= 0.25f && BalanceScript.compressor >= 0.25f && BalanceScript.turbine >= 0.25f && BalanceScript.engine >= 0.25f && BalanceScript.ramjet >= 0.25f && BalanceScript.nozzle >= 0.25f)
            {

                BalanceScript.currentFuel -= BalanceScript.rocketTank;
                BalanceScript.rocketCurrent = BalanceScript.rocketTank;
                FuelAndTemp.tank = 1f;
                damage = Random.Range(BalanceScript.maxDamage, BalanceScript.minDamage);
                BalanceScript.air -= damage;
                damage = Random.Range(BalanceScript.maxDamage, BalanceScript.minDamage);
                BalanceScript.cooler -= damage;
                damage = Random.Range(BalanceScript.maxDamage, BalanceScript.minDamage);
                BalanceScript.compressor -= damage;
                damage = Random.Range(BalanceScript.maxDamage, BalanceScript.minDamage);
                BalanceScript.turbine -= damage;
                damage = Random.Range(BalanceScript.maxDamage, BalanceScript.minDamage);
                BalanceScript.engine -= damage;
                damage = Random.Range(BalanceScript.maxDamage, BalanceScript.minDamage);
                BalanceScript.ramjet -= damage;
                damage = Random.Range(BalanceScript.maxDamage, BalanceScript.minDamage);
                BalanceScript.nozzle -= damage;
                customCanvas.SetActive(false);
                playCanvas.SetActive(true);
                InfiniteBackground.checkIt = false;
                //isDissolving = true;
                 //fade = 1f;
                 //material.SetFloat("_Fade", fade);
                //scrollOff.SetActive(false);
                //exitOff.SetActive(false);

            }
            else
            {
                repairButton.SetActive(true);
                refuelButton.SetActive(false);
                playButton.SetActive(false);
                popUp.text = "\n" + "Your engine status is critical!";
                noFuel.Play("Nofuel Animation");
            }
        }
        else
        {
            repairButton.SetActive(false);
            refuelButton.SetActive(true);
            playButton.SetActive(false);
            popUp.text = "\n " + "No enough fuel";
            noFuel.Play("Nofuel Animation");
        }
    }
    public void ReverseAnim()
    {
        noFuel.Play("Reverse fuel Animation");
    }
    public void HomeButton()
    {
        fade = 0f;
        material.SetFloat("_Fade", fade);
        isDissolving = false;
    }
}
