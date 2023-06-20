using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewJobsTimer : MonoBehaviour {
 
   public Transform[] cards;

   private int counter = 0;
   private void OnEnable() {
      counter = 0;

      foreach (Transform card in cards) {
         Debug.Log(card.GetComponent<WorkPlace>().GetbuttonText());
         if (card.GetComponent<WorkPlace>().GetbuttonText() == "Completed") {
            counter++;
         }
      }

      if (counter > 6) {
            foreach (Transform card in cards) {
               card.GetComponent<WorkPlace>().SetNewJob();
            }
         }
    Debug.Log(counter);
      }
     
     
   }

   // private void DisplayTime(float timeToDisplay) {
   //    if (timeToDisplay < 0) {
   //       timeToDisplay = 0;
   //    }
   //
   //    float minutes = Mathf.FloorToInt(timeToDisplay / 60);
   //    float seconds = Mathf.FloorToInt(timeToDisplay % 60);
   //
   //    timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
   // }

