using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Flying : MonoBehaviour
{
    public AudioSource clip1;
    public AudioSource clip2;
    public ParticleSystem ps_Engine;
    public ParticleSystem ps_Engine2;
    public ParticleSystem ps_Engine3;
    public ParticleSystem ps_Engine4;
    public ParticleSystem ps_Engine5;
    public ParticleSystem ps_Engine6;
    public ParticleSystem ps_Engine7;
    public ParticleSystem ps_Engine8;
    public ParticleSystem ps_Engine9;
    public ParticleSystem ps_Engine10;
    public Rigidbody2D rb;
    public static bool fly;
    public static bool stock = true;
    public GameObject boom;
    public Text moneyText;
    private float money;
    public static int moneyToInt;
    public RectTransform canvasRect;
    private float rectNumb = 0.00900621f;
    private float rectNumb2 = 0.01020621f;
    public GameObject menuButton;
    public ParticleSystem ps_speed;
    public Image boostFill;
    private bool boosted;
    public ParticleSystem ps_boostPart;
    private bool offPart;
    public Text speedMeter;
    private float reachedSpeed;
    private float checkSpeed;
    public static bool newPlanet1 = false;
    public static bool newPlanet2 = false;
    public static bool newPlanet3 = false;
    public static bool newPlanet4 = false;
    public static bool newPlanet5 = false;
    public static bool newPlanet6 = false;
    public static bool newPlanet7 = false;
    public static bool newPlanet8 = false;
    public static bool newPlanet9 = false;
    public GameObject unlockedBH;
    private bool boomCheck = false;

    private bool speedPartCheck = false;

    private bool bhPlanet9;
    public GameObject balanceScript;
    
    void Start()
    {
        stock = true;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Monetization.revived == true)
        {
            stock = true;
        }
        checkSpeed = reachedSpeed;
        reachedSpeed = rb.velocity.y;
        if(checkSpeed > reachedSpeed && BalanceScript.topSpeed < checkSpeed)
        {
            BalanceScript.topSpeed = checkSpeed;
        }else if(reachedSpeed > checkSpeed && BalanceScript.topSpeed < reachedSpeed)
        {
            BalanceScript.topSpeed = reachedSpeed;
        }
        speedMeter.text = reachedSpeed + " km/s";
        if (!boom.activeSelf && stock == false)
        {
            if (reachedSpeed <= -1f)
            {
                boom.SetActive(true);
            }
        }
        if (boostFill.fillAmount < 1f)
        {
            if (boosted == false)
            {
                boostFill.fillAmount += 0.1f * Time.deltaTime;
            }
        }
        else
        {
            if (offPart == false)
            {
                ps_boostPart.Play();
                offPart = true;
            }
        }
        if (boosted == true)
        {
            offPart = false;
            if (boostFill.fillAmount > 0f)
            {
                boostFill.fillAmount -= 2f * Time.deltaTime;
            }
            else
            {
                boosted = false;
            }
        }
        if (stock == false)
        {
            if (fly == true)
            {
                if (!boom.activeSelf)
                rb.AddForce(new Vector2(0, BalanceScript.speedFly) * Time.deltaTime);
                if (rectNumb < rectNumb2)
                {
                    rectNumb2 -= 0.0005f * Time.deltaTime;
                    canvasRect.localScale = new Vector3(rectNumb2, 0.01020621f, 0.01020621f);
                }
            }
            else if (fly == false)
            {
                //OnPointerUp();
                if (rectNumb2 <= 0.0100621) 
                {
                    rectNumb2 += 0.001f * Time.deltaTime;
                    canvasRect.localScale = new Vector3(rectNumb2, 0.01020621f, 0.01020621f);
                }
                if (boom.activeSelf)
                {
                    rb.velocity = Vector2.zero;
                    if(rb.transform.position.y <= -1.78f)
                    {
                        rb.AddForce(new Vector2(0, 500f) * Time.deltaTime);
                    }
                }

            }
            if (ChosePlanet.activated9 == true && rb.transform.position.y >= 1500f)
            {
                if (bhPlanet9 == false)
                {
                    newPlanet9 = true;
                    unlockedBH.SetActive(true);
                    BalanceScript.bhUnlocked = true;
                    balanceScript.GetComponent<BalanceScript>().Save();
                    bhPlanet9 = true;
                }
            }

        } else if (stock == true)
        {
            rb.gravityScale = 0f;
        }
        if(reachedSpeed > 20f)
        {
            if (speedPartCheck == false)
            {
                ps_speed.Play();
                speedPartCheck = true;
            }
        }else
        {
            if (speedPartCheck == true)
            {
                ps_speed.Stop();
                speedPartCheck = false;
            }
        }
        if (boom.activeSelf && boomCheck == false)
        {
            boomCheck = true;
            money = rb.transform.position.y * BalanceScript.reward;
            moneyToInt = (int)money;
            moneyText.text = "$" + moneyToInt.ToString() + " Shards";
            OnPointerUp();
            CheckPlanets();
        }
    }

    public void BoostON()
    {
        if (boostFill.fillAmount >= 1f)
        {
            clip1.Play();
            boosted = true;
            rb.AddForce(new Vector2(0, BalanceScript.boostSpeed));
            ps_boostPart.Stop();
            stock = false;
            rb.gravityScale = 1f;
        }
        else
        {
            clip2.Play();
        }
    }
    public void OnPointerDown()
    {
        if(Monetization.revived == true)
        {
            Monetization.revived = false;
        }
        boomCheck = false;
        fly = true;
        stock = false;
        rb.gravityScale = 1f;
        StartEngine();
        menuButton.SetActive(false);
    }
    public void OnPointerUp()
    {
        fly = false;
        ShutEngine();
    }

    public void ClaimMoney()
    {
        BalanceScript.balance += moneyToInt;
    }

    void StartEngine()
    {
        ps_Engine.Play();
        ps_Engine2.Play();
        ps_Engine3.Play();
        ps_Engine4.Play();
        ps_Engine5.Play();
        ps_Engine6.Play();
        ps_Engine7.Play();
        ps_Engine8.Play();
        ps_Engine9.Play();
        ps_Engine10.Play();
    }
    void ShutEngine()
    {
        ps_Engine.Stop();
        ps_Engine2.Stop();
        ps_Engine3.Stop();
        ps_Engine4.Stop();
        ps_Engine5.Stop();
        ps_Engine6.Stop();
        ps_Engine7.Stop();
        ps_Engine8.Stop();
        ps_Engine9.Stop();
        ps_Engine10.Stop();
    }
    void CheckPlanets()
    {
        if (ChosePlanet.activated1 == true && rb.transform.position.y >= 150f)
        {
            newPlanet1 = true;
        }
        else if (ChosePlanet.activated2 == true && rb.transform.position.y >= 300f)
        {
            newPlanet2 = true;
        }
        else if (ChosePlanet.activated3 == true && rb.transform.position.y >= 450f)
        {
            newPlanet3 = true;
        }
        else if (ChosePlanet.activated4 == true && rb.transform.position.y >= 600f)
        {
            newPlanet4 = true;
        }
        else if (ChosePlanet.activated5 == true && rb.transform.position.y >= 750f)
        {
            newPlanet5 = true;
        }
        else if (ChosePlanet.activated6 == true && rb.transform.position.y >= 900f)
        {
            newPlanet6 = true;
        }
        else if (ChosePlanet.activated7 == true && rb.transform.position.y >= 1050f)
        {
            newPlanet7 = true;
        }
        else if (ChosePlanet.activated8 == true && rb.transform.position.y >= 1200f)
        {
            newPlanet8 = true;
        }
    }
}
