using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollBarUpgrade : MonoBehaviour
{
    private int number = 0;
    //public Image currentImage1;
    //public Image currentImage2;
    //public Image currentImage3;
    //public Image currentImage4;
    //public Image currentImage5;
    //public Image currentImage6;
    //public Image currentImage7;
    //public Image currentImage8;
    //public Sprite greenImage;
    //public Sprite blackImage;
    public GameObject scrollbar;
    private float scroll_pos = 0;
    float[] pos;

    void Update()
    {
        pos = new float[transform.childCount];
        float distance = 1f / (pos.Length - 1f);
        for (int i = 0; i < pos.Length; i++)
        {
            number++;
            pos[i] = distance * i;
        }

        if (Input.GetMouseButton(0))
        {
            scroll_pos = scrollbar.GetComponent<Scrollbar>().value;
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
                transform.GetChild(i).localScale = Vector2.Lerp(transform.GetChild(i).localScale, new Vector2(1.1f, 1.3f), 0.1f);
                for (int j = 0; j < pos.Length; j++)
                {
                    if (j != i)
                    {
                        transform.GetChild(j).localScale = Vector2.Lerp(transform.GetChild(j).localScale, new Vector2(0.8f, 0.8f), 0.1f);
                    }
                }
            }
        }
        /*if (scroll_pos > 1.2 || scroll_pos < 0.0715)
        {
            currentImage1.sprite = greenImage;
            currentImage2.sprite = blackImage;
            currentImage3.sprite = blackImage;
            currentImage4.sprite = blackImage;
            currentImage5.sprite = blackImage;
            currentImage6.sprite = blackImage;
            currentImage7.sprite = blackImage;
            currentImage8.sprite = blackImage;
        }
        else if (scroll_pos >= 0.0715 && scroll_pos < 0.2143)
        {
            currentImage2.sprite = greenImage;
            currentImage1.sprite = blackImage;
            currentImage3.sprite = blackImage;
            currentImage4.sprite = blackImage;
            currentImage5.sprite = blackImage;
            currentImage6.sprite = blackImage;
            currentImage7.sprite = blackImage;
            currentImage8.sprite = blackImage;
        }
        else if (scroll_pos >= 0.2143 && scroll_pos < 0.357)
        {
            currentImage3.sprite = greenImage;
            currentImage2.sprite = blackImage;
            currentImage1.sprite = blackImage;
            currentImage4.sprite = blackImage;
            currentImage5.sprite = blackImage;
            currentImage6.sprite = blackImage;
            currentImage7.sprite = blackImage;
            currentImage8.sprite = blackImage;
        }
        else if (scroll_pos >= 0.357 && scroll_pos < 0.5)
        {
            currentImage4.sprite = greenImage;
            currentImage2.sprite = blackImage;
            currentImage3.sprite = blackImage;
            currentImage1.sprite = blackImage;
            currentImage5.sprite = blackImage;
            currentImage6.sprite = blackImage;
            currentImage7.sprite = blackImage;
            currentImage8.sprite = blackImage;
        }
        else if (scroll_pos >= 0.5 && scroll_pos < 0.6428)
        {
            currentImage5.sprite = greenImage;
            currentImage2.sprite = blackImage;
            currentImage3.sprite = blackImage;
            currentImage4.sprite = blackImage;
            currentImage1.sprite = blackImage;
            currentImage6.sprite = blackImage;
            currentImage7.sprite = blackImage;
            currentImage8.sprite = blackImage;
        }
        else if (scroll_pos >= 0.6428 && scroll_pos < 0.7856)
        {
            currentImage6.sprite = greenImage;
            currentImage2.sprite = blackImage;
            currentImage3.sprite = blackImage;
            currentImage4.sprite = blackImage;
            currentImage5.sprite = blackImage;
            currentImage1.sprite = blackImage;
            currentImage7.sprite = blackImage;
            currentImage8.sprite = blackImage;
        }
        else if (scroll_pos >= 0.7856 && scroll_pos < 0.9285)
        {
            currentImage7.sprite = greenImage;
            currentImage2.sprite = blackImage;
            currentImage3.sprite = blackImage;
            currentImage4.sprite = blackImage;
            currentImage5.sprite = blackImage;
            currentImage6.sprite = blackImage;
            currentImage1.sprite = blackImage;
            currentImage8.sprite = blackImage;
        }
        else if (scroll_pos >= 0.9285 && scroll_pos < 1.1)
        {
            currentImage8.sprite = greenImage;
            currentImage2.sprite = blackImage;
            currentImage3.sprite = blackImage;
            currentImage4.sprite = blackImage;
            currentImage5.sprite = blackImage;
            currentImage6.sprite = blackImage;
            currentImage7.sprite = blackImage;
            currentImage1.sprite = blackImage;
        }*/
    }
}
