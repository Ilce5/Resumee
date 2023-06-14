using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ThemeScript : MonoBehaviour
{
    public Sprite orange1;
    public Sprite orange2;
    public Sprite orange3;
    public Sprite black1;
    public Sprite black2;
    public Sprite black3;
    public Sprite red1;
    public Sprite red2;
    public Sprite red3;
    public Sprite purple1;
    public Sprite purple2;
    public Sprite purple3;
    public Sprite aqua1;
    public Sprite aqua2;
    public Sprite aqua3;

    public Image bg;
    public Image bgU;
    public Image bgR;
    public Image bgT;
    public Image button1;
    public Image button2;
    public Image button3;
    public Image button4;
    public Image button5;

    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject object4;
    public GameObject object5;

    public Button red;
    public Button purple;
    public Button black;
    public Button aqua;
    public GameObject lock1;
    public GameObject lock2;
    public GameObject lock3;
    public GameObject lock4;
    public GameObject padLock;
    public GameObject bh;
    public GameObject approved;

    public ParticleSystem part1;
    public ParticleSystem part2;
    public ParticleSystem part3;
    public ParticleSystem part4;

    public GameObject balanceScript;
    void Start()
    {
        balanceScript.GetComponent<BalanceScript>().Load();
        part1.Play();
        part2.Play();
        part3.Play();
        part4.Play();
        if (BalanceScript.finished == true)
        {
            approved.SetActive(true);
        }
        if(BalanceScript.bhUnlocked == true)
        {
            Debug.Log("works ");
            padLock.SetActive(false);
            bh.SetActive(true);
        }
        if (BalanceScript.checkTheme1 == true)
        {
            OrangeChange();
        }
        else if (BalanceScript.checkTheme2 == true)
        {
            RedChange();
        }
        else if (BalanceScript.checkTheme3 == true)
        {
            PurpleChange();
        }
        else if (BalanceScript.checkTheme4 == true)
        {
            BlackChange();
        }
        else if (BalanceScript.checkTheme5 == true)
        {
            AquaChange();
        }
        CheckPlanets();
    }
    public void CheckPlanets()
    {
        if (BalanceScript.unlockedPlanets >= 2)
        {
            red.interactable = true;
            lock1.SetActive(false);
        }else
        {
            BalanceScript.checkTheme1 = true;
        }
        if(BalanceScript.unlockedPlanets >= 4)
        {
            purple.interactable = true;
            lock2.SetActive(false);
        }
        if(BalanceScript.unlockedPlanets >= 6)
        {
            black.interactable = true;
            lock3.SetActive(false);
        }
        if(BalanceScript.unlockedPlanets >= 8)
        {
            aqua.interactable = true;
            lock4.SetActive(false);
        }
    }
    public void OrangeChange()
    {
        TurnOff();
        BalanceScript.checkTheme1 = true;
        bg.sprite = orange1;
        bgU.sprite = orange1;
        bgR.sprite = orange1;
        bgT.sprite = orange3;
        button1.sprite = orange2;
        button2.sprite = orange2;
        button3.sprite = orange2;
        button4.sprite = orange2;
        button5.sprite = orange2;
        DontPlay();
        object1.SetActive(true);

    }
    public void RedChange()
    {
        TurnOff();
        BalanceScript.checkTheme2 = true;
        bg.sprite = red1;
        bgU.sprite = red1;
        bgR.sprite = red1;
        bgT.sprite = red3;
        button1.sprite = red2;
        button2.sprite = red2;
        button3.sprite = red2;
        button4.sprite = red2;
        button5.sprite = red2;
        DontPlay();
        object2.SetActive(true);
    }
    public void PurpleChange()
    {
        TurnOff();
        BalanceScript.checkTheme3 = true;
        bg.sprite = purple1;
        bgU.sprite = purple1;
        bgR.sprite = purple1;
        bgT.sprite = purple3;
        button1.sprite = purple2;
        button2.sprite = purple2;
        button3.sprite = purple2;
        button4.sprite = purple2;
        button5.sprite = purple2;
        DontPlay();
        object3.SetActive(true);
    }
    public void BlackChange()
    {
        TurnOff();
        BalanceScript.checkTheme4 = true;
        bg.sprite = black1;
        bgU.sprite = black1;
        bgR.sprite = black1;
        bgT.sprite = black3;
        button1.sprite = black2;
        button2.sprite = black2;
        button3.sprite = black2;
        button4.sprite = black2;
        button5.sprite = black2;
        DontPlay();
        object4.SetActive(true);
    }
    public void AquaChange()
    {
        TurnOff();
        BalanceScript.checkTheme5 = true;
        bg.sprite = aqua1;
        bgU.sprite = aqua1;
        bgR.sprite = aqua1;
        bgT.sprite = aqua3;
        button1.sprite = aqua2;
        button2.sprite = aqua2;
        button3.sprite = aqua2;
        button4.sprite = aqua2;
        button5.sprite = aqua2;
        DontPlay();
        object5.SetActive(true);
    }
    void DontPlay()
    {
        object1.SetActive(false);
        object2.SetActive(false);
        object3.SetActive(false);
        object4.SetActive(false);
        object5.SetActive(false);
    }
    void TurnOff()
    {
        BalanceScript.checkTheme1 = false;
        BalanceScript.checkTheme2 = false;
        BalanceScript.checkTheme3 = false;
        BalanceScript.checkTheme4 = false;
        BalanceScript.checkTheme5 = false;
    }

    public void SceneAnimation()
    {
        BalanceScript.playAnimation = 0;
    }
}
