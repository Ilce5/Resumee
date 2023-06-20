using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccDelay : MonoBehaviour
{
    public GameObject background;

    public void TryIt()
    {
        Invoke("Iskluci", 0.50f);
    }
    public void Iskluci()
    {
        background.SetActive(false);
    }
    public void AcceptLearnTryIt()
    {
        Invoke("Iskluci", 1.4f);
    }
    public void LearnAcceptTryIt()
    {
        Invoke("Iskluci", 1.4f);
    }
}
