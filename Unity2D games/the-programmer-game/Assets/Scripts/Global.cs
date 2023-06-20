using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Global : MonoBehaviour
{
    public static Global Instance { get; private set; }
    
    [SerializeField] private Text dashboardActiveCodeText;
    [SerializeField] private Text balanceText;
    [SerializeField] private Text upgradeCanvasExperienceText;
    private int Experience;
    private int balance;
    private int level;

   

    private string ACTIVE_LANG;

    private bool isWorking = false;
   
    private List<string> knownLanguages = new List<string>(){"Java"};

    private Text text_ref;
    
    public void UpdateActiveJobText(string newActiveJob)
    {
        this.dashboardActiveCodeText.text = ("Current Job - " + newActiveJob );
    }
    

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateBalance(10000000);
        UpdateActiveJobText("None");
        UpdateKnownLanguages();
        SetLevel(19);
        Debug.Log(knownLanguages.ToString());
        
    }

    public void UpdateBalanceText()
    {
        balanceText.text = "Current Balance" + "\n" + "$" + balance;
    }
    public void UpdateBalance(int ammount)
    {
        balance += ammount;
        UpdateBalanceText();
    }
    public void setBalance(int ammount)
    {
        balance = ammount;
        UpdateBalanceText();
    }

    public int GetBalance()
    {
        return balance;
    }
    
  
    public void UpdateExperienceText()
    {
        upgradeCanvasExperienceText.text = Experience.ToString();
    }
    public void UpdateExperience(int ammount)
    {
        Experience += ammount;
        UpdateExperienceText();
    }
    
    public void setExperience(int ammount)
    {
        Experience = ammount;
        UpdateExperienceText();
    }


    public void SetLevel(int ammount)
    {
        level = ammount;
        UpdateKnownLanguages();
    }

    public void UpdateLevelText()
    {
        
    }

    public int GetLevel()
    {
        return level;
    }

    public void UpdateKnownLanguages()
    {
        if (level >= 5)
        {
            knownLanguages.Add("Cplus");
        }
        if (level >= 8)
        {
            knownLanguages.Add("Python");
        }
        if (level >= 13)
        {
            knownLanguages.Add("Html");
        }
        if (level >= 16)
        {
            knownLanguages.Add("CSharp");
        }
        if (level >= 18)
        {
            knownLanguages.Add("JavaScript");
        }
        if (level >= 20)
        {
            knownLanguages.Add("Pascal");
        }
      
    }

    public List<String> GetKnwonLanguages()
    {
        return knownLanguages;
    }

    public void updateActiveLang(string lang)
    {
        ACTIVE_LANG = lang;
    }

    public string getActiveLang()
    {
        return ACTIVE_LANG;
    }

    public void JobFinished(int moneyReward , int xpReward) {
        UpdateBalance(moneyReward);
        UpdateExperience(xpReward);
            
        isWorking = false;
        text_ref.text = "Completed";
        ACTIVE_LANG = " ";
        UpdateActiveJobText("none");
    }

    public void Job_Started(Text text) {
        isWorking = true;
        text_ref = text;
    }

    public bool GetJobStatus() {
        return isWorking;
    }

    public int GetExperience() {
        return Experience;
    }
    
}
