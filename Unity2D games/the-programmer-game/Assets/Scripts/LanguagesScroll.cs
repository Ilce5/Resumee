using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguagesScroll : MonoBehaviour
{
   
    public GameObject scrollbar;
    private float scroll_pos = 0;
    float[] pos;

    void Update()
    {
        
        pos = new float[transform.childCount];
        float distance = 1f / (pos.Length - 1f);
        for (int i = 0; i < pos.Length; i++)
        {
          
            pos[i] = distance * i;
        }

        if (Input.GetMouseButton(0))
        {
            scroll_pos = scrollbar.GetComponent<Scrollbar>().value;
            print(GetLangangueIndex());
        }
        else
        {
            for (int i = 0; i < pos.Length; i++)
            {
                if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance / 2))
                {
                    scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, pos[i], 0.1f);
                }
            }
        }


        for (int i = 0; i < pos.Length; i++)
        {
            if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance / 2))
            {
                transform.GetChild(i).localScale = Vector2.Lerp(transform.GetChild(i).localScale, new Vector2(1f, 1f), 0.06f);
                for (int j = 0; j < pos.Length; j++)
                {
                    if (j != i)
                    {
                        transform.GetChild(j).localScale = Vector2.Lerp(transform.GetChild(j).localScale, new Vector2(0.6f, 0.6f), 0.06f);
                    }
                }
            }
        }
        
       
    }

    public int GetLangangueIndex()
    {
        if (scroll_pos > -1 && scroll_pos < 0.085f)
        {
            return 0;
        }
        if (scroll_pos >0.085f && scroll_pos < 0.24f)
        {
            return 1;
        }
        if (scroll_pos > 0.24f && scroll_pos < 0.395f)
        {
            return 2;
        }
        if (scroll_pos > 0.395f && scroll_pos < 0.57f)
        {
            return 3;
        }
        if (scroll_pos >0.57f && scroll_pos < 0.74f)
        {
            return 4;
        }
        if (scroll_pos >0.74f && scroll_pos < 0.91f)
        {
            return 5;
        }
        else
        {
            return 6;
        }
    }
}
