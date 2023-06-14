using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayRepair : MonoBehaviour
{
    public GameObject main;
    public GameObject repair;
    public Animator anim;

    public void Iskluci()
    {
        anim.Play("RepairClick Animation");
        Invoke("ActionCanvas", 0.5f);
    }
    public void ActionCanvas()
    {
        main.SetActive(false);
        repair.SetActive(true);
    }
    public void IskluciReverse()
    {
        Invoke("ReverseAction", 0.4f);
    }
    public void ReverseAction()
    {
        main.SetActive(true);
        repair.SetActive(false);
        anim.Play("RepairReverse");
    }
}
