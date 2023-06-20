using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IDEUpgrade : MonoBehaviour
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

    public Text nameOfUpgrade;
    public Text buyButtonText;
    public GameObject notif;
    public GameObject noXp;
    public Sprite fullUpgrade;
    private bool exitCheck = false;
    private int xpBalanceint = 5000;

    public int priceOfSyn = 600;
    public int priceOfCodeC = 600;
    public int priceOfSource = 600;
    public int priceOfVersion = 600;
    public int priceOfDebug = 600;
    public int priceOfCodeS = 600;
    public int priceOfVisual = 600;
    public int priceOfAuto = 600;
    public int priceOfRefra = 600;
    public int priceOfCodeAT = 600;

    public void SyntaxHighlighting()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("IDENotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Syntax highlighting";
        buyButtonText.text = "Buy for " + priceOfSyn.ToString() + "xp";
    }
    public void CodeCompletion()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("IDENotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Code completion";
        buyButtonText.text = "Buy for " + priceOfCodeC.ToString() + "xp";
    }
    public void SourceCodeRefactoringTools()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("IDENotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Source code refactoring tools";
        buyButtonText.text = "Buy for " + priceOfSource.ToString() + "xp";
    }
    public void VersionControl()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("IDENotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Version control";
        buyButtonText.text = "Buy for " + priceOfVersion.ToString() + "xp";
    }
    public void Debugging()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("IDENotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Debugging";
        buyButtonText.text = "Buy for " + priceOfDebug.ToString() + "xp";
    }
    public void CodeSearch()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("IDENotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Code search";
        buyButtonText.text = "Buy for " + priceOfCodeS.ToString() + "xp";
    }
    public void VisualProgramming()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("IDENotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Visual programming";
        buyButtonText.text = "Buy for " + priceOfVisual.ToString() + "xp";
    }
    public void AutomatedRefactoring()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("IDENotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Automated refactoring";
        buyButtonText.text = "Buy for " + priceOfAuto.ToString() + "xp";
    }
    public void Refactoring()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("IDENotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Refactoring";
        buyButtonText.text = "Buy for " + priceOfRefra.ToString() + "xp";
    }
    public void CodeAnalysisTools()
    {
        if (exitCheck == false)
        {
            notif.SetActive(true);
            anim.Play("IDENotificationAnimation");
            exitCheck = true;
        }
        nameOfUpgrade.text = "Code analysis tools";
        buyButtonText.text = "Buy for " + priceOfCodeAT.ToString() + "xp";
    }
    public void Bought()
    {
        if (nameOfUpgrade.text == "Syntax highlighting")
        {
            if (checkU1 == false)
            {
                if (xpBalanceint >= priceOfSyn)
                {
                    checkU1 = true;
                    xpBalanceint -= priceOfSyn;
                    upgrade1.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }

        }
        else if (nameOfUpgrade.text == "Code completion")
        {
            if (checkU2 == false)
            {
                if (xpBalanceint >= priceOfCodeC)
                {
                    checkU2 = true;
                    xpBalanceint -= priceOfCodeC;
                    upgrade2.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Source code refactoring tools")
        {
            if (checkU3 == false)
            {
                if (xpBalanceint >= priceOfSource)
                {
                    checkU3 = true;
                    xpBalanceint -= priceOfSource;
                    upgrade3.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Version control")
        {
            if (checkU4 == false)
            {
                if (xpBalanceint >= priceOfVersion)
                {
                    checkU4 = true;
                    xpBalanceint -= priceOfVersion;
                    upgrade4.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Debugging")
        {
            if (checkU5 == false)
            {
                if (xpBalanceint >= priceOfDebug)
                {
                    checkU5 = true;
                    xpBalanceint -= priceOfDebug;
                    upgrade5.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Code search")
        {
            if (checkU6 == false)
            {
                if (xpBalanceint >= priceOfCodeS)
                {
                    checkU6 = true;
                    xpBalanceint -= priceOfCodeS;
                    upgrade6.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Visual programming")
        {
            if (checkU7 == false)
            {
                if (xpBalanceint >= priceOfVisual)
                {
                    checkU7 = true;
                    xpBalanceint -= priceOfVisual;
                    upgrade7.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Automated refactoring")
        {
            if (checkU8 == false)
            {
                if (xpBalanceint >= priceOfAuto)
                {
                    checkU8 = true;
                    xpBalanceint -= priceOfAuto;
                    upgrade8.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Refactoring")
        {
            if (checkU9 == false)
            {
                if (xpBalanceint >= priceOfRefra)
                {
                    checkU9 = true;
                    xpBalanceint -= priceOfRefra;
                    upgrade9.sprite = fullUpgrade;
                }
                else
                    noXp.SetActive(true);
                anim.Play("NoXpAnimation");
            }
        }
        else if (nameOfUpgrade.text == "Code analysis tools")
        {
            if (checkU10 == false)
            {
                if (xpBalanceint >= priceOfCodeAT)
                {
                    checkU10 = true;
                    xpBalanceint -= priceOfCodeAT;
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
        anim.Play("ReverseIDENotificationAnimation");
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
    public Image upgrade10;
}
