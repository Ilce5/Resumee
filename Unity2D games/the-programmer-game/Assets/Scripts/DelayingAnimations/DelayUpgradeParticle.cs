using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayUpgradeParticle : MonoBehaviour
{
    public GameObject particle1;
    public GameObject particle2;
    public GameObject particle3;
    public GameObject particle4;
    public GameObject particle5;
    public GameObject particle6;
    public GameObject particle7;
    public GameObject particle8;
    public GameObject particle9;
    public GameObject particle10;

    public void TryIt1()
    {
        particle1.SetActive(true);
        Invoke("Iskluci1", 4f);
    }
    public void Tryit2()
    {
        particle2.SetActive(true);
        Invoke("Iskluci2", 4f);
    }
    public void Tryit3()
    {
        particle3.SetActive(true);
        Invoke("Iskluci3", 4f);
    }
    public void Tryit4()
    {
        particle4.SetActive(true);
        Invoke("Iskluci4", 4f);
    }
    public void Tryit5()
    {
        particle5.SetActive(true);
        Invoke("Iskluci5", 4f);
    }
    public void Tryit6()
    {
        particle6.SetActive(true);
        Invoke("Iskluci6", 4f);
    }
    public void Tryit7()
    {
        particle7.SetActive(true);
        Invoke("Iskluci7", 4f);
    }
    public void Tryit8()
    {
        particle8.SetActive(true);
        Invoke("Iskluci8", 4f);
    }
    public void Tryit9()
    {
        particle9.SetActive(true);
        Invoke("Iskluci9", 4f);
    }
    public void Tryit10()
    {
        particle10.SetActive(true);
        Invoke("Iskluci10", 4f);
    }
    public void Iskluci1()
    {
        particle1.SetActive(false);

    }
    public void Iskluci2()
    {
        particle2.SetActive(false);

    }
    public void Iskluci3()
    {
        particle3.SetActive(false);

    }
    public void Iskluci4()
    {
        particle4.SetActive(false);

    }
    public void Iskluci5()
    {
        particle5.SetActive(false);

    }
    public void Iskluci6()
    {
        particle6.SetActive(false);

    }
    public void Iskluci7()
    {
        particle7.SetActive(false);

    }
    public void Iskluci8()
    {
        particle8.SetActive(false);

    }
    public void Iskluci9()
    {
        particle9.SetActive(false);

    }
    public void Iskluci10()
    {
        particle10.SetActive(false);

    }
}
