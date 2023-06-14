using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChosePlanet : MonoBehaviour
{
    public static bool activated1;
    public static bool activated2;
    public static bool activated3;
    public static bool activated4;
    public static bool activated5;
    public static bool activated6;
    public static bool activated7;
    public static bool activated8;
    public static bool activated9;
    public GameObject part1;
    public GameObject part2;
    public Scrollbar hscrollbar;
    private float countTime = 0f;

    private bool done = false;

    public GameObject dissolveScript;

    public Image planet2;
    public ParticleSystem explode2;
    public Image planet3;
    public ParticleSystem explode3;
    public Image planet4;
    public ParticleSystem explode4;
    public Image planet5;
    public ParticleSystem explode5;
    public Image planet6;
    public ParticleSystem explode6;
    public Image planet7;
    public ParticleSystem explode7;
    public Image planet8;
    public ParticleSystem explode8;
    public Image planet9;
    public ParticleSystem explode9;

    public GameObject blockImage;
    public Animator anim;

    public GameObject visibleImage2;
    public GameObject visibleImage3;
    public GameObject visibleImage4;
    public GameObject visibleImage5;
    public GameObject visibleImage6;
    public GameObject visibleImage7;
    public GameObject visibleImage8;
    public GameObject visibleImage9;
    public GameObject visibleImage10;

    public GameObject repairButton;
    public GameObject refuelButton;
    public GameObject playButton;
    public Text bhText;

    public Sprite stand1;
    public Sprite stand2;
    public Sprite stand3;
    public Image stand;

    public static bool particlesDisable = false;
    public GameObject rocketParticle;
    public GameObject fireParticle;
    private bool checkUnlocked = false;
    public GameObject saveScript;
    void Update()
    {
        if (checkUnlocked == false)
        {
            if (BalanceScript.unlockedPlanets >= 2)
            {
                planet2.color = new Color32(255, 255, 255, 255);
                Flying.newPlanet1 = true;
            }
            if (BalanceScript.unlockedPlanets >= 3)
            {
                planet3.color = new Color32(255, 255, 255, 255);
                Flying.newPlanet2 = true;
            }
            if (BalanceScript.unlockedPlanets >= 4)
            {
                planet4.color = new Color32(255, 255, 255, 255);
                Flying.newPlanet3 = true;
            }
            if (BalanceScript.unlockedPlanets >= 5)
            {
                planet5.color = new Color32(255, 255, 255, 255);
                Flying.newPlanet4 = true;
            }
            if (BalanceScript.unlockedPlanets >= 6)
            {
                planet6.color = new Color32(255, 255, 255, 255);
                Flying.newPlanet5 = true;
            }
            if (BalanceScript.unlockedPlanets >= 7)
            {
                planet7.color = new Color32(255, 255, 255, 255);
                Flying.newPlanet6 = true;
            }
            if (BalanceScript.unlockedPlanets >= 8)
            {
                planet8.color = new Color32(255, 255, 255, 255);
                Flying.newPlanet7 = true;
            }
            if (BalanceScript.unlockedPlanets >= 9)
            {
                planet9.color = new Color32(255, 255, 255, 255);
                Flying.newPlanet8 = true;
            }
            checkUnlocked = true;
        }

        if (Flying.newPlanet1 == true)
        {
            if (BalanceScript.unlockedPlanets < 2)
            {
                blockImage.SetActive(true);
                ScrollMap.scroll_pos = 0.125f;
                particlesDisable = true;
                if (done == false)
                {
                    explode2.Play();
                    done = true;
                }
                planet2.color = Color.Lerp(planet2.color, Color.white, Time.deltaTime);
                countTime += Time.deltaTime;
                if (countTime > 4f)
                {
                    done = false;
                    BalanceScript.unlockedPlanets++;
                    countTime = 0f;
                    blockImage.SetActive(false);
                    saveScript.GetComponent<BalanceScript>().Save();
                }
            }
        }
        if (Flying.newPlanet2 == true)
        {
            if (BalanceScript.unlockedPlanets < 3)
            {
                blockImage.SetActive(true);
                ScrollMap.scroll_pos = 0.250f;
                particlesDisable = true;
                if (done == false)
                {
                    explode3.Play();
                    done = true;
                }
                planet3.color = Color.Lerp(planet3.color, Color.white, Time.deltaTime);
                countTime += Time.deltaTime;
                if (countTime > 4f)
                {
                    done = false;
                    BalanceScript.unlockedPlanets++;
                    countTime = 0f;
                    blockImage.SetActive(false);
                    saveScript.GetComponent<BalanceScript>().Save();
                }
            }
        }
         if (Flying.newPlanet3 == true)
        {
            if (BalanceScript.unlockedPlanets < 4)
            {
                blockImage.SetActive(true);
                ScrollMap.scroll_pos = 0.375f;
                particlesDisable = true;
                if (done == false)
                {
                    explode4.Play();
                    done = true;
                }
                planet4.color = Color.Lerp(planet4.color, Color.white, Time.deltaTime);
                countTime += Time.deltaTime;
                if (countTime > 4f)
                {
                    done = false;
                    BalanceScript.unlockedPlanets++;
                    countTime = 0f;
                    blockImage.SetActive(false);
                    saveScript.GetComponent<BalanceScript>().Save();
                }
            }
        }
         if (Flying.newPlanet4 == true)
        {
            if (BalanceScript.unlockedPlanets < 5)
            {
                blockImage.SetActive(true);
                ScrollMap.scroll_pos = 0.5f;
                particlesDisable = true;
                if (done == false)
                {
                    explode5.Play();
                    done = true;
                }
                planet5.color = Color.Lerp(planet5.color, Color.white, Time.deltaTime);
                countTime += Time.deltaTime;
                if (countTime > 4f)
                {
                    done = false;
                    BalanceScript.unlockedPlanets++;
                    countTime = 0f;
                    blockImage.SetActive(false);
                    saveScript.GetComponent<BalanceScript>().Save();
                }
            }
        }
         if (Flying.newPlanet5 == true)
        {
            if (BalanceScript.unlockedPlanets < 6)
            {
                blockImage.SetActive(true);
                ScrollMap.scroll_pos = 0.625f;
                particlesDisable = true;
                if (done == false)
                {
                    explode6.Play();
                    done = true;
                }
                planet6.color = Color.Lerp(planet6.color, Color.white, Time.deltaTime);
                countTime += Time.deltaTime;
                if (countTime > 4f)
                {
                    done = false;
                    BalanceScript.unlockedPlanets++;
                    countTime = 0f;
                    blockImage.SetActive(false);
                    saveScript.GetComponent<BalanceScript>().Save();
                }
            }
        }
         if (Flying.newPlanet6 == true)
        {
            if (BalanceScript.unlockedPlanets < 7)
            {
                blockImage.SetActive(true);
                ScrollMap.scroll_pos = 0.750f;
                particlesDisable = true;
                if (done == false)
                {
                    explode7.Play();
                    done = true;
                }
                planet7.color = Color.Lerp(planet7.color, Color.white, Time.deltaTime);
                countTime += Time.deltaTime;
                if (countTime > 4f)
                {
                    done = false;
                    BalanceScript.unlockedPlanets++;
                    countTime = 0f;
                    blockImage.SetActive(false);
                    saveScript.GetComponent<BalanceScript>().Save();
                }
            }
        }
         if (Flying.newPlanet7 == true)
        {
            if (BalanceScript.unlockedPlanets < 8)
            {
                blockImage.SetActive(true);
                ScrollMap.scroll_pos = 0.875f;
                particlesDisable = true;
                if (done == false)
                {
                    explode8.Play();
                    done = true;
                }
                planet8.color = Color.Lerp(planet8.color, Color.white, Time.deltaTime);
                countTime += Time.deltaTime;
                if (countTime > 4f)
                {
                    done = false;
                    BalanceScript.unlockedPlanets++;
                    countTime = 0f;
                    blockImage.SetActive(false);
                    saveScript.GetComponent<BalanceScript>().Save();
                }
            }
        }
         if (Flying.newPlanet8 == true)
        {
            if (BalanceScript.unlockedPlanets < 9)
            {
                blockImage.SetActive(true);
                ScrollMap.scroll_pos = 1f;
                particlesDisable = true;
                if (done == false)
                {
                    explode9.Play();
                    done = true;
                }
                planet9.color = Color.Lerp(planet9.color, Color.white, Time.deltaTime);
                countTime += Time.deltaTime;
                if (countTime > 4f)
                {
                    done = false;
                    BalanceScript.unlockedPlanets++;
                    countTime = 0f;
                    blockImage.SetActive(false);
                    saveScript.GetComponent<BalanceScript>().Save();
                }
            }
        }
         if (Flying.newPlanet9 == true)
        {
            if (BalanceScript.bhUnlocked == false)
            {
                anim.Play("Nofuel Animation");
                repairButton.SetActive(false);
                refuelButton.SetActive(false);
                playButton.SetActive(true);
                bhText.text = "\n" + "Blackhole unlocked!";
                BalanceScript.bhUnlocked = true;
                saveScript.GetComponent<BalanceScript>().Save();
            }

        }
         if(particlesDisable == true)
        {
            rocketParticle.SetActive(false);
            fireParticle.SetActive(false);
        }
        else
        {
            rocketParticle.SetActive(true);
            fireParticle.SetActive(true);
        }
    }

    public void Planet1()
    {
        DeactivateIt();
        activated1 = true;
        visibleImage2.SetActive(true);
        stand.sprite = stand1;
        dissolveScript.GetComponent<Dissolve>().PlayClick();
    }
    public void Planet2()
    {
        if(Flying.newPlanet1 == true)
        {
            DeactivateIt();
            activated2 = true;
            visibleImage3.SetActive(true);
            stand.sprite = stand1;
            dissolveScript.GetComponent<Dissolve>().PlayClick();
        }
    }
    public void Planet3()
    {
        if (Flying.newPlanet2 == true)
        {
            DeactivateIt();
            activated3 = true;
            visibleImage4.SetActive(true);
            stand.sprite = stand1;
            dissolveScript.GetComponent<Dissolve>().PlayClick();
        }
    }
    public void Planet4()
    {
        if (Flying.newPlanet3 == true)
        {
            DeactivateIt();
            activated4 = true;
            visibleImage5.SetActive(true);
            stand.sprite = stand2;
            dissolveScript.GetComponent<Dissolve>().PlayClick();
        }
    }
    public void Planet5()
    {
        if (Flying.newPlanet4 == true)
        {
            DeactivateIt();
            activated5 = true;
            visibleImage6.SetActive(true);
            stand.sprite = stand2;
            dissolveScript.GetComponent<Dissolve>().PlayClick();
        }
    }
    public void Planet6()
    {
        if (Flying.newPlanet5 == true)
        {
            DeactivateIt();
            activated6 = true;
            visibleImage7.SetActive(true);
            stand.sprite = stand2;
            dissolveScript.GetComponent<Dissolve>().PlayClick();
        }
    }
    public void Planet7()
    {
        if (Flying.newPlanet6 == true)
        {
            DeactivateIt();
            activated7 = true;
            visibleImage8.SetActive(true);
            stand.sprite = stand3;
            dissolveScript.GetComponent<Dissolve>().PlayClick();
        }
    }
    public void Planet8()
    {
        if (Flying.newPlanet7 == true)
        {
            DeactivateIt();
            activated8 = true;
            visibleImage9.SetActive(true);
            stand.sprite = stand3;
            dissolveScript.GetComponent<Dissolve>().PlayClick();
        }
    }
    public void Planet9()
    {
        if (Flying.newPlanet8 == true)
        {
            DeactivateIt();
            activated9 = true;
            //visibleImage10.SetActive(true);
            stand.sprite = stand3;
            dissolveScript.GetComponent<Dissolve>().PlayClick();
        }
    }

    public void DeactivateIt()
    {
        activated1 = false;
        activated2 = false;
        activated3 = false;
        activated4 = false;
        activated5 = false;
        activated6 = false;
        activated7 = false;
        activated8 = false;
        activated9 = false;
        visibleImage2.SetActive(false);
        visibleImage3.SetActive(false);
        visibleImage4.SetActive(false);
        visibleImage5.SetActive(false);
        visibleImage6.SetActive(false);
        visibleImage7.SetActive(false);
        visibleImage8.SetActive(false);
        visibleImage9.SetActive(false);
        visibleImage10.SetActive(false);
    }
    public void BackButton()
    {
        particlesDisable = false;
        checkUnlocked = false;
    }
}
