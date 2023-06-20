using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeOption : MonoBehaviour
{
    public Animator anim;

    private bool checkU1 = false;
    private bool checkU2 = false;
    private bool checkU3 = false;
    private bool checkU4 = false;
    private bool checkU5 = false;
    private bool checkU6 = false;
    private bool checkU7 = false;
    private bool checkU8 = false;
    private bool checkU9 = false;
    private bool checkU10 = false;

    public GameObject test;

    public Text nameOfUpgrade;
    public Text buyButtonText;
    public GameObject notif;
    public GameObject noXp;
    public Sprite fullUpgrade;
    private bool exitCheck = false;
    private int xpBalanceint = 5000;

    public int priceOfSym = 600;
    public int priceOfUnix = 600;
    public int priceOfGnome = 600;
    public int priceOfAsym = 600;
    public int priceOfMWindows = 600;
    public int priceOfDirectX = 600;
    public int priceOfOpenHMPP = 600;
    public int priceOfLinux = 600;
    public int priceOfVulkan = 600;
    public int priceOfOpenACC = 600;

    public void SymmetricMultiprocessing()
    {
        if (exitCheck == false)
        {
           // test.SetActive(false);  
            notif.SetActive(true);
                //anim.Play("ComputerNotificationAnimation");
            anim.Play("FirstButtonAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Symmetric Multiprocessing";
        buyButtonText.text = "Buy for " + priceOfSym.ToString() + "xp";
    }
    public void Unix()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("ComputerNotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Unix";
        buyButtonText.text = "Buy for " + priceOfUnix.ToString() + "xp";
    }
    public void GNOME()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("ComputerNotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "GNOME";
        buyButtonText.text = "Buy for " + priceOfGnome.ToString() + "xp";
    }
    public void AsymmetricMultiprocessing()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("ComputerNotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Asymmetric Multiprocessing";
        buyButtonText.text = "Buy for " + priceOfAsym.ToString() + "xp";
    }
    public void MicrosoftWindows()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("ComputerNotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Microsoft   Windows";
        buyButtonText.text = "Buy for " + priceOfMWindows.ToString() + "xp";
    }
    public void DirectX()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("ComputerNotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "DirectX";
        buyButtonText.text = "Buy for " + priceOfDirectX.ToString() + "xp";
    }
    public void OpenHMPP()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("ComputerNotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "OpenHMPP";
        buyButtonText.text = "Buy for " + priceOfOpenHMPP.ToString() + "xp";
    }
    public void Linux()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("ComputerNotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Linux";
        buyButtonText.text = "Buy for " + priceOfLinux.ToString() + "xp";
    }
    public void Vulkan()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("ComputerNotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Vulkan";
        buyButtonText.text = "Buy for " + priceOfVulkan.ToString() + "xp";
    }
    public void OpenACC()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("ComputerNotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "OpenACC";
        buyButtonText.text = "Buy for " + priceOfOpenACC.ToString() + "xp";
    }
    public void Bought()
    {
        if (nameOfUpgrade.text == "Symmetric Multiprocessing")
        {
            if (checkU1 == false)
            {
                if (xpBalanceint >= priceOfSym)
                {
                    checkU1 = true;
                    xpBalanceint -= priceOfSym;
                    upgrade1.sprite = fullUpgrade;
                    upgradeTest.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }

        }else if(nameOfUpgrade.text == "Unix")
        {
            if (checkU2 == false)
            {
                if (xpBalanceint >= priceOfUnix)
                {
                    checkU2 = true;
                    xpBalanceint -= priceOfUnix;
                    upgrade2.sprite = fullUpgrade;
                }
                else
                noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "GNOME")
        {
            if (checkU3 == false)
            {
                if (xpBalanceint >= priceOfGnome)
                {
                    checkU3 = true;
                    xpBalanceint -= priceOfGnome;
                    upgrade3.sprite = fullUpgrade;
                }
                else
                noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Asymmetric Multiprocessing")
        {
            if (checkU4 == false)
            {
                if (xpBalanceint >= priceOfAsym)
                {
                    checkU4 = true;
                    xpBalanceint -= priceOfAsym;
                    upgrade4.sprite = fullUpgrade;
                }
                else
                noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Microsoft   Windows")
        {
            if (checkU5 == false)
            {
                if (xpBalanceint >= priceOfMWindows)
                {
                    checkU5 = true;
                    xpBalanceint -= priceOfMWindows;
                    upgrade5.sprite = fullUpgrade;
                }
                else
                noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "DirectX")
        {
            if (checkU6 == false)
            {
                if (xpBalanceint >= priceOfDirectX)
                {
                    checkU6 = true;
                    xpBalanceint -= priceOfDirectX;
                    upgrade6.sprite = fullUpgrade;
                }
                else
                noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "OpenHMPP")
        {
            if (checkU7 == false)
            {
                if (xpBalanceint >= priceOfOpenHMPP)
                {
                    checkU7 = true;
                    xpBalanceint -= priceOfOpenHMPP;
                    upgrade7.sprite = fullUpgrade;
                }
                else
                noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Linux")
        {
            if (checkU8 == false)
            {
                if (xpBalanceint >= priceOfLinux)
                {
                    checkU8 = true;
                    xpBalanceint -= priceOfLinux;
                    upgrade8.sprite = fullUpgrade;
                }
                else
                noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Vulkan")
        {
            if (checkU9 == false)
            {
                if (xpBalanceint >= priceOfVulkan)
                {
                    checkU9 = true;
                    xpBalanceint -= priceOfVulkan;
                    upgrade9.sprite = fullUpgrade;
                }
                else
                noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "OpenACC")
        {
            if (checkU10 == false)
            {
                if (xpBalanceint >= priceOfOpenACC)
                {
                    checkU10 = true;
                    xpBalanceint -= priceOfOpenACC;
                    upgrade10.sprite = fullUpgrade;
                }
                else
                noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
    }
    public void Exitit()
    {
        //anim.Play("ReverseComputerNotificationAnimation");
        anim.Play("ReverseFirstButtonAnimation");
        Invoke("DelayExit", 0.2f);
    }
    private void DelayExit()
    {
        buttonAnim.SetActive(false);
        exitCheck = false;
        notif.SetActive(false);
        //test.SetActive(true);
    }

    public GameObject buttonAnim;

    public void testTransform()
    {
        thatObject.SetActive(true);
        thatObject.transform.position = test.transform.position;
    }
    public GameObject thatObject;


    public Image upgrade1;
    public Image upgrade2;
    public Image upgrade3;
    public Image upgrade4;
    public Image upgrade5;
    public Image upgrade6;
    public Image upgrade7;
    public Image upgrade8;
    public Image upgrade9;
    public Image upgrade10;
    public Image upgradeTest;
}
