using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetPlayCanvas : MonoBehaviour
{
    public RectTransform rocket;
    public Image rocket2;
    public GameObject playCanvas;
    public GameObject rocketCanvas;
    public GameObject death;
    public GameObject engineParticle;
    public GameObject explodeParticle;
    public Rigidbody2D rb;
    public Image boostImage;


    public void Reset()
    {
        rb.gravityScale = 1f;
        FuelAndTemp.tank = 1f;
        StartCoroutine(ChangeCanvas());

    }
    public void ResetAd()
    {
        playCanvas.SetActive(false);
        rocketCanvas.SetActive(true);
        death.SetActive(false);
        engineParticle.SetActive(true);
        explodeParticle.SetActive(false);
        rocket2.color = new Color(rocket2.color.r, rocket2.color.g, rocket2.color.b, 255f);
        rocket.position = new Vector3(0f, -1.78f, 0f);
        rb.gravityScale = 0f;
        boostImage.fillAmount = 1f;
    }
    IEnumerator ChangeCanvas()
    {
        yield return new WaitForSeconds(0.8f);
        playCanvas.SetActive(false);
        rocketCanvas.SetActive(true);
        death.SetActive(false);
        engineParticle.SetActive(true);
        explodeParticle.SetActive(false);
        rocket2.color = new Color(rocket2.color.r, rocket2.color.g, rocket2.color.b, 255f);
        rocket.position = new Vector3(0f, -1.78f, 0f);
        rb.gravityScale = 0f;
        boostImage.fillAmount = 1f;

    }
    IEnumerator ChangeCanvasAd()
    {
        yield return new WaitForSeconds(0.8f);
        death.SetActive(false);
        engineParticle.SetActive(true);
        explodeParticle.SetActive(false);
        rocket2.color = new Color(rocket2.color.r, rocket2.color.g, rocket2.color.b, 255f);
        rocket.position = new Vector3(0f, -1.78f, 0f);
        rb.gravityScale = 0f;
        boostImage.fillAmount = 1f;
    }
}
