using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpController : MonoBehaviour {
  
  public static PopUpController Instance { get; private set; }
  
  [SerializeField] private GameObject PopUp_AlreadyHaveAnActiveJob;
  [SerializeField] private GameObject PopUp_NoActiveJobSelected;
  [SerializeField] private GameObject PopUp_AlreadyAtMaxLevel;
  [SerializeField] private GameObject PopUp_NotEnoughMoney;
  [Header("JOB COMPLETED")]
  [SerializeField] private GameObject PopUp_JobCompleted;
  [SerializeField] private Text money_Reward;
  [SerializeField] private Text exp_Reward;

  public void Awake() {
    Instance = this;
  }

  public void UsePopUp_AlreadyHaveJob() {
    PopUp_AlreadyHaveAnActiveJob.SetActive(true);
  }
  public void UsePopUp_NoActiveJobSeleted () {
    PopUp_NoActiveJobSelected.SetActive(true);
  }
  public void UsePopUp_AlreadyAtMaxLevel () {
    PopUp_AlreadyAtMaxLevel.SetActive(true);
  }
  public void UsePopUp_NotEnoughMoney () {
    PopUp_NotEnoughMoney.SetActive(true);
  }
  public void UsePopUp_JobCompleted(int money_reward , int exp_reward ) {
    this.money_Reward.text = "Money : " + money_reward + " $";
    this.exp_Reward.text = "Experience : " + exp_reward + " xp";
    PopUp_JobCompleted.SetActive(true);
    
  }
}
