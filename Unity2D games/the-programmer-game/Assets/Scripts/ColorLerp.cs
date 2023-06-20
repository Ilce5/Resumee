using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorLerp : MonoBehaviour
{
    public Image imageRenderer;

    public static ColorLerp Instance { get; private set; }

    private float lerpTime = 2f;
    

    public Color[] myColors;


    private void Awake()
    {
        Instance = this;
    }


    public void Update()
    {
        ColorLerpMethod();
    }

    public void ColorLerpMethod()
    {
        if (ShopContoller.Instance.GetIndex() == 0)
        {
            imageRenderer.color = Color.Lerp(
                imageRenderer.color, myColors[0], lerpTime * Time.deltaTime );
        }
        else if (ShopContoller.Instance.GetIndex() == 1)
        {
            imageRenderer.color = Color.Lerp(
                imageRenderer.color, myColors[1], lerpTime * Time.deltaTime);
           
        }
        else if (ShopContoller.Instance.GetIndex() == 2)
        {
            imageRenderer.color = Color.Lerp(
                imageRenderer.color, myColors[2], lerpTime * Time.deltaTime );
        }
       else  if (ShopContoller.Instance.GetIndex() == 3)
        {
            imageRenderer.color = Color.Lerp(
                imageRenderer.color, myColors[3], lerpTime * Time.deltaTime);
        }
       else if (ShopContoller.Instance.GetIndex() == 4)
        {
            imageRenderer.color = Color.Lerp(
                imageRenderer.color, myColors[4], lerpTime * Time.deltaTime);
        }
        else if (ShopContoller.Instance.GetIndex() == 5)
        {
            imageRenderer.color = Color.Lerp(
                imageRenderer.color, myColors[5], lerpTime * Time.deltaTime);
        }
       else if (ShopContoller.Instance.GetIndex() == 6)
        {
            imageRenderer.color = Color.Lerp(
                imageRenderer.color, myColors[6], lerpTime * Time.deltaTime);
        }
        else if (ShopContoller.Instance.GetIndex() == 7)
        {
            imageRenderer.color = Color.Lerp(
                imageRenderer.color, myColors[7], lerpTime * Time.deltaTime);
        }
       
     


    }




}