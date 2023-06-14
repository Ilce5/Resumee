using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delaying : MonoBehaviour
{
    public GameObject start;
    public GameObject game;
    public GameObject part;
    private Animator anim;

    void Start()
    {
        anim = game.GetComponent<Animator>();
    }
    public void Iskluci()
    {
        Invoke("OffAnim", 1f);
    }
    public void OffAnim()
    {
        part.SetActive(false);
        start.SetActive(false);
        game.SetActive(true);
        anim.Play("Fade");
    }
    public void IskluciMain()
    {
        Invoke("UpgradeAnim", 1f);
        BalanceScript.playAnimation = 0;
    }
    public void UpgradeAnim()
    {
        start.SetActive(false);
        game.SetActive(true);
        part.SetActive(false);
    }
    public void IskluciUpgrade()
    {
        Invoke("UpgradeAnim", 1.3f);
    }
}
