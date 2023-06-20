using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOrOffUpgrade : MonoBehaviour
{
    public GameObject particle;
    private int check = 0;

    public void Switch()
    {
        check++;
        if (check == 1)
        {
            check -= 2;
            particle.SetActive(true);
        }
        else if (check == 0)
        {
            particle.SetActive(false);
        }
    }
}
