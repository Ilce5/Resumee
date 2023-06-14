using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class RocketsCanvas : MonoBehaviour
{
    public AudioSource clip;
    public AudioSource clip2;
    public Sprite alphaS;
    public Sprite svenS;
    public Sprite titanS;
    public Sprite nukeS;
    public Sprite phalaenopsisS;
    public Sprite celestialS;
    public Sprite falconS;
    public Sprite amethystS;
    public Sprite oracleS;
    public Sprite dynamoS;

    private string alphaTxt = "Lift: 9%" + "\n" + "Weight: 80%" + "\n" + "Drag: 63%" + "\n" + "Thrust: 35%";
    private string svenTxt = "Lift: 14%" + "\n" + "Weight: 78%" + "\n" + "Drag: 53%" + "\n" + "Thrust: 39%";
    private string titanTxt = "Lift: 28%" + "\n" + "Weight: 54%" + "\n" + "Drag: 49%" + "\n" + "Thrust: 40%";
    private string nukeTxt = "Lift: 25%" + "\n" + "Weigh: 69%" + "\n" + "Drag: 49%" + "\n" + "Thrust: 62%";
    private string phalaenopsisTxt = "Lift: 25%" + "\n" + "Weight: 60%" + "\n" + "Drag: 36%" + "\n" + "Thrust: 50%";
    private string celestialTxt = "Lift: 43%" + "\n" + "Weight: 66%" + "\n" + "Drag: 40%" + "\n" + "Thrust: 40%";
    private string falconTxt = "Lift: 40%" + "\n" + "Weight: 60%" + "\n" + "Drag: 30%" + "\n" + "Thrust: 69%";
    private string amethystTxt = "Lift: 58%" + "\n" + "Weight: 49%" + "\n" + "Drag: 32%" + "\n" + "Thrust: 70%";
    private string oracleTxt = "Lift: 60%" + "\n" + "Weight: 35%" + "\n" + "Drag: 30%" + "\n" + "Thrust: 77%";
    private string dynamoTxt = "Lift: 82%" + "\n" + "Weight: 20%" + "\n" + "Drag: 19%" + "\n" + "Thrust: 91%";

    public Image rocket;
    public Text info;
    public Text nameOf;

    public ParticleSystem part1;
    public ParticleSystem part2;
    public ParticleSystem part3;
    public ParticleSystem part4;
    public GameObject purchaseButton;
    private int numRocket;
    public Animator anim;
    private int priceForRocket;
    public Text rocketPrice;
    public Button backButton;

    public Image alphaI;
    public Image svenI;
    public Image titanI;
    public Image nukeI;
    public Image phalaenopsisI;
    public Image celestialI;
    public Image falconI;
    public Image amethystI;
    public Image oracleI;
    public Image oblivionI;

    void Start()
    {
        if(BalanceScript.rcheck2 == true)
        {
            svenI.color = new Color32(255, 255, 255, 255);
        }
        if (BalanceScript.rcheck3 == true)
        {
            titanI.color = new Color32(255, 255, 255, 255);
        }
        if (BalanceScript.rcheck4 == true)
        {
            nukeI.color = new Color32(255, 255, 255, 255);
        }
        if (BalanceScript.rcheck5 == true)
        {
            phalaenopsisI.color = new Color32(255, 255, 255, 255);
        }
        if (BalanceScript.rcheck6 == true)
        {
            celestialI.color = new Color32(255, 255, 255, 255);
        }
        if (BalanceScript.rcheck7 == true)
        {
            falconI.color = new Color32(255, 255, 255, 255);
        }
        if (BalanceScript.rcheck8 == true)
        {
            amethystI.color = new Color32(255, 255, 255, 255);
        }
        if (BalanceScript.rcheck9 == true)
        {
            oracleI.color = new Color32(255, 255, 255, 255);
        }
        if (BalanceScript.rcheck10 == true)
        {
            oblivionI.color = new Color32(255, 255, 255, 255);
        }
    }
    public void AlphaRocket()
    {
        anim.Play("Color Animation");
        purchaseButton.SetActive(false);
        rocket.sprite = alphaS;
        info.text = alphaTxt;
        nameOf.text = "Alpha";
    }
    public void SvenRocket()
    {
        if (BalanceScript.rcheck2 == false)
        {
            anim.Play("OffColor Animation");
            purchaseButton.SetActive(true);
            rocketPrice.text = "1000";
        }
        else
        {
            purchaseButton.SetActive(false);
            anim.Play("Color Animation");
        }
        rocket.sprite = svenS;
        info.text = svenTxt;
        nameOf.text = "Sven";
        numRocket = 2;
    }
    public void TitanRocket()
    {
        if (BalanceScript.rcheck3 == false)
        {
            anim.Play("OffColor Animation");
            purchaseButton.SetActive(true);
            rocketPrice.text = "2000";
        }
        else
        {
            purchaseButton.SetActive(false);
            anim.Play("Color Animation");
        }
        rocket.sprite = titanS;
        info.text = titanTxt;
        nameOf.text = "Titan";
        numRocket = 3;
    }
    public void NukeRocket()
    {
        if (BalanceScript.rcheck4 == false)
        {
            anim.Play("OffColor Animation");
            purchaseButton.SetActive(true);
            rocketPrice.text = "3000";
        }
        else
        {
            purchaseButton.SetActive(false);
            anim.Play("Color Animation");
        }
        rocket.sprite = nukeS;
        info.text = nukeTxt;
        nameOf.text = "Nuke";
        numRocket = 4;
    }
    public void PhalaenopsisRocket()
    {
        if (BalanceScript.rcheck5 == false)
        {
            anim.Play("OffColor Animation");
            purchaseButton.SetActive(true);
            rocketPrice.text = "4000";
        }
        else
        {
            purchaseButton.SetActive(false);
            anim.Play("Color Animation");
        }
        rocket.sprite = phalaenopsisS;
        info.text = phalaenopsisTxt;
        nameOf.text = "Rosa";
        numRocket = 5;
    }
    public void CelestialRocket()
    {
        if (BalanceScript.rcheck6 == false)
        {
            anim.Play("OffColor Animation");
            purchaseButton.SetActive(true);
            rocketPrice.text = "5000";
        }
        else
        {
            purchaseButton.SetActive(false);
            anim.Play("Color Animation");
        }
        rocket.sprite = celestialS;
        info.text = celestialTxt;
        nameOf.text = "Celestial";
        numRocket = 6;
    }
    public void FalconRocket()
    {
        if (BalanceScript.rcheck7 == false)
        {
            anim.Play("OffColor Animation");
            purchaseButton.SetActive(true);
            rocketPrice.text = "6000";
        }
        else
        {
            purchaseButton.SetActive(false);
            anim.Play("Color Animation");
        }
        rocket.sprite = falconS;
        info.text = falconTxt;
        nameOf.text = "Falcon";
        numRocket = 7;
    }
    public void AmethystRocket()
    {
        if (BalanceScript.rcheck8 == false)
        {
            anim.Play("OffColor Animation");
            purchaseButton.SetActive(true);
            rocketPrice.text = "7000";
        }
        else
        {
            purchaseButton.SetActive(false);
            anim.Play("Color Animation");
        }
        rocket.sprite = amethystS;
        info.text = amethystTxt;
        nameOf.text = "Amethyst";
        numRocket = 8;
    }
    public void OracleRocket()
    {
        if (BalanceScript.rcheck9 == false)
        {
            anim.Play("OffColor Animation");
            purchaseButton.SetActive(true);
            rocketPrice.text = "8000";
        }
        else
        {
            purchaseButton.SetActive(false);
            anim.Play("Color Animation");
        }
        rocket.sprite = oracleS;
        info.text = oracleTxt;
        nameOf.text = "Oracle";
        numRocket = 9;
    }
    public void DynamoRocket()
    {
        if (BalanceScript.rcheck10 == false)
        {
            anim.Play("OffColor Animation");
            purchaseButton.SetActive(true);
            rocketPrice.text = "10 000";
        }
        else
        {
            purchaseButton.SetActive(false);
            anim.Play("Color Animation");

        }
        rocket.sprite = dynamoS;
        info.text = dynamoTxt;
        nameOf.text = "Oblivion";
        numRocket = 10;
    }

    public void PurchaseButton()
    {
        if (BalanceScript.balance >= 1000 && numRocket == 2)
        {
            priceForRocket = 1000;
            Purchased();
            BalanceScript.rcheck2 = true;
            StartCoroutine(wait2());
        }
        else if (BalanceScript.balance >= 2000 && numRocket == 3)
        {
            priceForRocket = 2000;
            Purchased();
            BalanceScript.rcheck3 = true;
            StartCoroutine(wait3());
        }
        else if (BalanceScript.balance >= 3000 && numRocket == 4)
        {
            priceForRocket = 3000;
            Purchased();
            BalanceScript.rcheck4 = true;
            StartCoroutine(wait4());
        }
        else if (BalanceScript.balance >= 4000 && numRocket == 5)
        {
            priceForRocket = 4000;
            Purchased();
            BalanceScript.rcheck5 = true;
            StartCoroutine(wait5());
        }
        else if (BalanceScript.balance >= 5000 && numRocket == 6)
        {
            priceForRocket = 5000;
            Purchased();
            BalanceScript.rcheck6 = true;
            StartCoroutine(wait6());
        }
        else if (BalanceScript.balance >= 6000 && numRocket == 7)
        {
            priceForRocket = 6000;
            Purchased();
            BalanceScript.rcheck7 = true;
            StartCoroutine(wait7());
        }
        else if (BalanceScript.balance >= 7000 && numRocket == 8)
        {
            priceForRocket = 7000;
            Purchased();
            BalanceScript.rcheck8 = true;
            StartCoroutine(wait8());
        }
        else if (BalanceScript.balance >= 8000 && numRocket == 9)
        {
            priceForRocket = 8000;
            Purchased();
            BalanceScript.rcheck9 = true;
            StartCoroutine(wait9());
        }
        else if (BalanceScript.balance >= 10000 && numRocket == 10)
        {
            priceForRocket = 10000;
            Purchased();
            BalanceScript.rcheck10 = true;
            StartCoroutine(wait10());
        }
        else
        {
            clip2.Play();
        }
    }

    void Purchased()
    {
        BalanceScript.speedFly += 10f;
        alphaI.raycastTarget = false;
        svenI.raycastTarget = false;
        titanI.raycastTarget = false;
        nukeI.raycastTarget = false;
        phalaenopsisI.raycastTarget = false;
        celestialI.raycastTarget = false;
        falconI.raycastTarget = false;
        amethystI.raycastTarget = false;
        oracleI.raycastTarget = false;
        oblivionI.raycastTarget = false;
        backButton.interactable = false;
        purchaseButton.SetActive(false);
        BalanceScript.purchasedRockets++;
        BalanceScript.balance -= priceForRocket;
        part1.Play();
        part2.Play();
        part3.Play();
        part4.Play();
        anim.Play("Wave Animation");
        clip.Play();
    }
    IEnumerator wait2()
    {
        yield return new WaitForSeconds(6);
        svenI.color = new Color32(255, 255, 255, 255);
        ButtonsON();
    }
    IEnumerator wait3()
    {
        yield return new WaitForSeconds(6);
        titanI.color = new Color32(255, 255, 255, 255);
        ButtonsON();
    }
    IEnumerator wait4()
    {
        yield return new WaitForSeconds(6);
        nukeI.color = new Color32(255, 255, 255, 255);
        ButtonsON();
    }
    IEnumerator wait5()
    {
        yield return new WaitForSeconds(6);
        phalaenopsisI.color = new Color32(255, 255, 255, 255);
        ButtonsON();
    }
    IEnumerator wait6()
    {
        yield return new WaitForSeconds(6);
        celestialI.color = new Color32(255, 255, 255, 255);
        ButtonsON();
    }
    IEnumerator wait7()
    {
        yield return new WaitForSeconds(6);
        falconI.color = new Color32(255, 255, 255, 255);
        ButtonsON();
    }
    IEnumerator wait8()
    {
        yield return new WaitForSeconds(6);
        amethystI.color = new Color32(255, 255, 255, 255);
        ButtonsON();
    }
    IEnumerator wait9()
    {
        yield return new WaitForSeconds(6);
        oracleI.color = new Color32(255, 255, 255, 255);
        ButtonsON();
    }
    IEnumerator wait10()
    {
        yield return new WaitForSeconds(6);
        oblivionI.color = new Color32(255, 255, 255, 255);
        ButtonsON();
    }
    void ButtonsON()
    {
        backButton.interactable = true;
        alphaI.raycastTarget = true;
        svenI.raycastTarget = true;
        titanI.raycastTarget = true;
        nukeI.raycastTarget = true;
        phalaenopsisI.raycastTarget = true;
        celestialI.raycastTarget = true;
        falconI.raycastTarget = true;
        amethystI.raycastTarget = true;
        oracleI.raycastTarget = true;
        oblivionI.raycastTarget = true;
        backButton.interactable = true;
    }
    public void BackButt()
    {
        if(BalanceScript.rcheck2 == false && numRocket == 2)
        {
            anim.Play("Offclose Animation");
        }
        else if (BalanceScript.rcheck3 == false && numRocket == 3)
        {
            anim.Play("Offclose Animation");
        }
        else if (BalanceScript.rcheck4 == false && numRocket == 4)
        {
            anim.Play("Offclose Animation");
        }
        else if (BalanceScript.rcheck5 == false && numRocket == 5)
        {
            anim.Play("Offclose Animation");
        }
        else if (BalanceScript.rcheck6 == false && numRocket == 6)
        {
            anim.Play("Offclose Animation");
        }
        else if (BalanceScript.rcheck7 == false && numRocket == 7)
        {
            anim.Play("Offclose Animation");
        }
        else if (BalanceScript.rcheck8 == false && numRocket == 8)
        {
            anim.Play("Offclose Animation");
        }
        else if (BalanceScript.rcheck9 == false && numRocket == 9)
        {
            anim.Play("Offclose Animation");
        }
        else if (BalanceScript.rcheck10 == false && numRocket == 10)
        {
            anim.Play("Offclose Animation");
        }
        else
        {
            anim.Play("Close Animation");
        }
    }
}
