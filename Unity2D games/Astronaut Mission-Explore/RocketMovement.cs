using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RocketMovement : MonoBehaviour
{
    private float speed = 0.2f;
    public Transform rocket;
    public Slider rotation;
    public Image fuel;
    private float consumption = 0.015f;
    public Transform center;
    private float pullStrenght = 0.25f;
    private bool controling = true;
    private float temp;
    public Image temperature;
    private bool checkSet = false;
    private float ultyTimer;
    public ParticleSystem timerEffect;
    public ParticleSystem particleEffect;
    private bool tick1 = false;
    private bool tick2 = false;
    private bool tick3 = false;
    private bool tick4 = false;
    private bool chilling = false;
    public Sprite redGlow;
    public Sprite blueGlow;
    public Image tempControl;
    public Transform chill;
    private float fanRotation;
    public ParticleSystem explodeParticle;
    public Renderer rocketRender;
    public Animator anim;
    public ParticleSystem effectSystem1;
    public ParticleSystem effectSystem2;
    public GameObject enginePart;
    private bool doneDying = false;
    public GameObject testObject;
    private bool pauseGame = false;
    public GameObject coreObject;
    private bool finishedGame = false;

    private float timePause = 0f;
    private bool pauseSet = false;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (pauseGame == false)
        {
            if(pauseSet == true)
            {
                timePause += Time.deltaTime;
                if(timePause >= 0.4f)
                {
                    coreObject.SetActive(true);
                    pauseSet = false;
                    timePause = 0f;
                }
            }
            if (rocket.position.y > 4f)
            {
                testObject.SetActive(true);
                pauseGame = true;
                coreObject.SetActive(false);
                BalanceScript.finished = true;
            }
            if (rocket.position.x < 28.1f && rocket.position.x > 27.9f && rocket.position.y > -0.1f && rocket.position.y < 0.1f || temperature.fillAmount >= 1f)
            {
                if (doneDying == false)
                {
                    enginePart.SetActive(false);
                    explodeParticle.Play();
                    anim.Play("Death Animation");
                    rocketRender.enabled = false;
                    doneDying = true;
                }
            }
            else if (fuel.fillAmount <= 0f)
            {
                speed = 0f;
            }
            rocket.transform.Translate(0, speed * Time.deltaTime, 0);
            rocket.eulerAngles = Vector3.forward * rotation.value * -1f;
            fuel.fillAmount -= consumption * Time.deltaTime;
            rocket.transform.position = Vector2.MoveTowards(rocket.transform.position, new Vector2(center.transform.position.x, center.transform.position.y), pullStrenght * Time.deltaTime);
            if (controling == false)
            {
                temperature.fillAmount += temp * Time.deltaTime;
            }
            if (controling == true && temperature.fillAmount > 0.35f)
            {
                temperature.fillAmount -= temp * Time.deltaTime;
            }

            ultyTimer += Time.deltaTime;
            if (ultyTimer >= 3f && tick1 == false)
            {
                timerEffect.Play();
                tick1 = true;
            }
            if (ultyTimer >= 4f && tick2 == false)
            {
                timerEffect.Play();
                tick2 = true;
            }
            if (ultyTimer >= 5f && tick3 == false)
            {
                timerEffect.Play();
                tick3 = true;
            }
            if (ultyTimer >= 6f)
            {
                if (ultyTimer >= 6f && pullStrenght <= 9f)
                {
                    pullStrenght = 0.4f;
                    if(tick4 == false)
                    {
                        particleEffect.Play();
                        tick4 = true;
                    }
                }
                if (ultyTimer >= 9f)
                {
                    pullStrenght = 0.25f;
                    ultyTimer = 0f;
                    tick1 = false;
                    tick2 = false;
                    tick3 = false;
                    tick4 = false;
                }
            }
            if (chilling == true)
            {
                if (fanRotation < 20f)
                {
                    fanRotation += 10f * Time.deltaTime;
                }
            }
            else
            {
                if (fanRotation > 0f)
                {
                    fanRotation -= 5f * Time.deltaTime;
                }
                else
                    fanRotation = 0f;
            }
            chill.Rotate(new Vector3(0f, 0f, fanRotation));
        }
        else
        {
            if (pauseSet == false)
            {
                timePause += Time.deltaTime;
                if (timePause >= 0.15f)
                {
                    coreObject.SetActive(false);
                    pauseSet = true;
                    timePause = 0f;
                }
            }
        }
    }
    public void PauseGame()
    {
        pauseGame = true;
    }
    public void ResumeGame()
    {
        pauseGame = false;
    }
    public void waitForIt()
    {
        finishedGame = true;
        StartCoroutine(waitForSth());
        pauseGame = false;
    }
    IEnumerator waitForSth()
    {
        yield return new WaitForSeconds(0.5f);
        coreObject.SetActive(true);
        testObject.SetActive(false);
        PlayAgain();
    }

    public void BoostOn()
    {
            if (chilling == false)
            {
                if (controling == true)
                {
                    speed = 0.42f;
                    consumption = 0.028f;
                }
                else
                {
                    speed = 0.555f;
                    consumption = 0.033f;
                    temp = 0.15f;
                }
            }
    }
    public void BoostOff()
    {
            if (chilling == false)
            {
                if (controling == true)
                {
                    speed = 0.22f;
                    consumption = 0.01f;
                    temp = 0.03f;
                }
                else
                {
                    speed = 0.35f;
                    consumption = 0.025f;
                    temp = 0.037f;
                }
            }
    }

    public void TempControl()
    {
            if (controling == true)
            {
                controling = false;
                speed = 0.35f;
                consumption = 0.025f;
                temp = 0.037f;
                tempControl.sprite = redGlow;
            }
            else
            {
                controling = true;
                speed = 0.22f;
                consumption = 0.01f;
                temp = 0.03f;
                tempControl.sprite = blueGlow;
            }
    }

    public void ChillingOn()
    {
        if(controling == false)
        {
            checkSet = true;
        }
        chilling = true;
        controling = true;
        speed = 0f;
        temp = 0.25f;
        consumption = 0f;
    }
    public void ChillingOff()
    {
            if (checkSet == true)
            {
                controling = false;
                temp = 0.037f;
                speed = 0.35f;
                consumption = 0.1f;
                checkSet = false;
            }
            else
            {
                speed = 0.22f;
                temp = 0.03f;
                consumption = 0.01f;
            }
            chilling = false;
    }
    public void PlayAgain()
    {
        if(controling == true)
        {
            speed = 0.22f;
        }else if(controling == false)
        {
            speed = 0.35f;
        }
        fuel.fillAmount = 1f;
        temperature.fillAmount = 0.35f;
        if (finishedGame == false)
        {
            anim.Play("Reverse Animation");
        }
        rocketRender.enabled = true;
        enginePart.SetActive(true);
        effectSystem1.Stop();
        effectSystem2.Stop();
        rocket.position = new Vector3(28f, -2.676f, rocket.position.z);
        doneDying = false;
        pauseGame = false;
        finishedGame = false;
    }
    IEnumerator waitForActive()
    {
        yield return new WaitForSeconds(2);
        rocketRender.enabled = true;
        rocket.position = new Vector3(28f, -2.676f, rocket.position.z);
        enginePart.SetActive(true);
        doneDying = false;
    }
}
