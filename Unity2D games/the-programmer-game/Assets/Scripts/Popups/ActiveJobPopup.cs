using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ActiveJobPopup : MonoBehaviour
{
    public Transform box;
   
   
    private void OnEnable()
    {
        box.localPosition = new Vector2(-80f,-900f);
        box.LeanMoveY(-700f, 0.5f).setEaseOutExpo().setOnComplete(OnComplete).delay = 0.2f;
        
    }

    public void OnComplete()
        {
            box.LeanMoveY(-900f, 0.5f).setEaseOutExpo().setOnComplete(EndAnim).delay = 2f;
        }

        public void EndAnim()
        {
            gameObject.SetActive(false);
        }
    // delay before the anim happens
}
