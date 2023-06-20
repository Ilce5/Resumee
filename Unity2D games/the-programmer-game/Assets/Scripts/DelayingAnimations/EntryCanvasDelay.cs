using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryCanvasDelay : MonoBehaviour
{
    public GameObject particleCanvas;
    public GameObject otherCanvas;

    public void TryIt()
    {
        Invoke("Iskluci", 0.5f);
    }
    public void Iskluci()
    {
        particleCanvas.SetActive(false);
        otherCanvas.SetActive(false);
    }
}
