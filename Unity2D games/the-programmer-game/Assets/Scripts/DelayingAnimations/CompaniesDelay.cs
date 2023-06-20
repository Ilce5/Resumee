using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompaniesDelay : MonoBehaviour
{
    public GameObject companiesCanvas;
    public GameObject language1;
    public GameObject language2;
    public GameObject language3;
    public GameObject language4;
    public GameObject language5;
    public GameObject language6;
    public GameObject language7;

    public void TryIt()
    {
        Invoke("Iskluci", 0.50f);
    }
    public void Iskluci()
    {
        companiesCanvas.SetActive(false);
        language1.SetActive(false);
        language2.SetActive(false);
        language3.SetActive(false);
        language4.SetActive(false);
        language5.SetActive(false);
        language6.SetActive(false);
        language7.SetActive(false);
    }
}
