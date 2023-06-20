using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveWorkPopup : MonoBehaviour
{
   public Transform box;
   
   private void OnEnable()
   {
      box.localPosition = new Vector2(700f,-200f);
      box.LeanMoveX(100f, 0.5f).setEaseInCubic().setOnComplete(OnComplete);

   }
   public void OnComplete()
   {
        
      box.LeanMoveX(700f, 0.5f).setEaseOutExpo().setOnComplete(EndAnim).delay = 2f;
   }

   public void EndAnim()
   {
      gameObject.SetActive(false);
   }
}
