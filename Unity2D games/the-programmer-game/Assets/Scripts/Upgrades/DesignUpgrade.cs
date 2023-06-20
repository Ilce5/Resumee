using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesignUpgrade : MonoBehaviour
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

    public Text nameOfUpgrade;
    public Text buyButtonText;
    public GameObject notif;
    public GameObject noXp;
    public Sprite fullUpgrade;
    private bool exitCheck = false;
    private int xpBalanceint = 5000;

    public int priceOfInD = 600;
    public int priceOfPS = 600;
    public int priceOfIll = 600;
    public int priceOfPower = 600;
    public int priceOfPen = 600;
    public int priceOfVideo = 600;
    public int priceOfAnim = 600;
    public int priceOfEffect = 600;
    public int priceOf3D = 600;

    public void InDesign()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("DesignAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "InDesign";
        buyButtonText.text = "Buy for " + priceOfInD.ToString() + "xp";
    }
    public void PhotoShop()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("DesignAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Photoshop";
        buyButtonText.text = "Buy for " + priceOfPS.ToString() + "xp";
    }
    public void Illustrator()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("DesignAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Illustrator";
        buyButtonText.text = "Buy for " + priceOfIll.ToString() + "xp";
    }
    public void Powerpoint()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("DesignAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Powerpoint";
        buyButtonText.text = "Buy for " + priceOfPower.ToString() + "xp";
    }
    public void Pen()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("DesignAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Pen";
        buyButtonText.text = "Buy for " + priceOfPen.ToString() + "xp";
    }
    public void Video()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("DesignAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Video";
        buyButtonText.text = "Buy for " + priceOfVideo.ToString() + "xp";
    }
    public void Animations()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("DesignAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Animations";
        buyButtonText.text = "Buy for " + priceOfAnim.ToString() + "xp";
    }
    public void Effects()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("DesignAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Effects";
        buyButtonText.text = "Buy for " + priceOfEffect.ToString() + "xp";
    }
    public void Dimension()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("DesignAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "3D";
        buyButtonText.text = "Buy for " + priceOf3D.ToString() + "xp";
    }

    public void Bought()
    {
        if (nameOfUpgrade.text == "InDesign")
        {
            if (checkU1 == false)
            {
                if (xpBalanceint >= priceOfInD)
                {
                    checkU1 = true;
                    xpBalanceint -= priceOfInD;
                    upgrade1.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }

        }
        else if (nameOfUpgrade.text == "Photoshop")
        {
            if (checkU2 == false)
            {
                if (xpBalanceint >= priceOfPS)
                {
                    checkU2 = true;
                    xpBalanceint -= priceOfPS;
                    upgrade2.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Illustrator")
        {
            if (checkU3 == false)
            {
                if (xpBalanceint >= priceOfIll)
                {
                    checkU3 = true;
                    xpBalanceint -= priceOfIll;
                    upgrade3.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Powerpoint")
        {
            if (checkU4 == false)
            {
                if (xpBalanceint >= priceOfPower)
                {
                    checkU4 = true;
                    xpBalanceint -= priceOfPower;
                    upgrade4.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Pen")
        {
            if (checkU5 == false)
            {
                if (xpBalanceint >= priceOfPen)
                {
                    checkU5 = true;
                    xpBalanceint -= priceOfPen;
                    upgrade5.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Video")
        {
            if (checkU6 == false)
            {
                if (xpBalanceint >= priceOfVideo)
                {
                    checkU6 = true;
                    xpBalanceint -= priceOfVideo;
                    upgrade6.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Animations")
        {
            if (checkU7 == false)
            {
                if (xpBalanceint >= priceOfAnim)
                {
                    checkU7 = true;
                    xpBalanceint -= priceOfAnim;
                    upgrade7.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Effects")
        {
            if (checkU8 == false)
            {
                if (xpBalanceint >= priceOfEffect)
                {
                    checkU8 = true;
                    xpBalanceint -= priceOfEffect;
                    upgrade8.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "3D")
        {
            if (checkU9 == false)
            {
                if (xpBalanceint >= priceOf3D)
                {
                    checkU9 = true;
                    xpBalanceint -= priceOf3D;
                    upgrade9.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
    }

    public void Exitit()
    {
        anim.Play("ReverseDesignAnimation");
        Invoke("DelayExit", 0.4f);
    }

    private void DelayExit()
    {
        exitCheck = false;
        notif.SetActive(false);
    }






    public Image upgrade1;
    public Image upgrade2;
    public Image upgrade3;
    public Image upgrade4;
    public Image upgrade5;
    public Image upgrade6;
    public Image upgrade7;
    public Image upgrade8;
    public Image upgrade9;
}
