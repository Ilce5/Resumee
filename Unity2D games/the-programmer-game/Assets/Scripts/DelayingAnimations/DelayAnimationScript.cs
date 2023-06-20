using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayAnimationScript : MonoBehaviour
{
    public GameObject background;
    public GameObject mainMenuOn;
    public GameObject animationOff;

    public void TryIt()
    {
        animationOff.SetActive(true);
        Invoke("Iskluci", 0.29f);
    }
    public void Iskluci()
    {
        mainMenuOn.SetActive(true);
        background.SetActive(false);
        animationOff.SetActive(false);
    }
    public void TryItLater()
    {
        animationOff.SetActive(true);
        Invoke("Iskluci", 0.50f);
    }
}
