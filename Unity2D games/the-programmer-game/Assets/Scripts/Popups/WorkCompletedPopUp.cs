using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkCompletedPopUp : MonoBehaviour
{
    public Transform box;
   
   
    private void OnEnable()
    {
        box.localPosition = new Vector2(-50f,-950f);
        box.LeanMoveY(-630f, 0.5f).setEaseOutExpo().setOnComplete(OnComplete).delay = 0.2f;
        
    }

    public void OnComplete()
    {
        box.LeanMoveY(-950f, 0.5f).setEaseOutExpo().setOnComplete(EndAnim).delay = 4f;
    }
    public void OnBtnClose() {
        box.LeanMoveY(-950f, 0.5f).setEaseOutExpo().setOnComplete(EndAnim);
    }

    public void EndAnim()
    {
        gameObject.SetActive(false);
    }
    // delay before the anim happens
}

