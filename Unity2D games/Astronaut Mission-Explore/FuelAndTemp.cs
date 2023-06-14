using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelAndTemp : MonoBehaviour
{
    public float refuel = 0.3f;
    public static float tank = 1f;
    static bool flying;
    public Image FuelTank;

    //Temp
    public float high = 0.2f;
    public float temp = 0.1f;
    public Material glowMat;
    public float glow = 0f;
    public Image Temperature;
    public GameObject explode;
    public Image rocket;
    public GameObject engines;
    public GameObject death;
    private bool outOfFuel = false;

    void FixedUpdate()
    {
        FuelConsumption();
    }

    public void FuelConsumption()
    {
        FuelTank.fillAmount = tank;
        glowMat.EnableKeyword("_EMISSION");
        if (flying == true)
        {
            if (death.activeSelf)
            {
                StopConsumption();
            }
            else
            {
                outOfFuel = false;
            }

            if (tank > 0f)
            {
                BalanceScript.rocketCurrent -= BalanceScript.consumption * Time.deltaTime;
                tank = BalanceScript.rocketCurrent / BalanceScript.rocketTank;
            }
            else
            {
                //for unlimited fuel
                Flying.fly = false;
                outOfFuel = true;
            }

            if (temp < 1f)
            {
                if (outOfFuel == false)
                {
                    temp += high * Time.deltaTime;
                    Temperature.fillAmount = temp;
                    glow = temp * 2f;
                    glowMat.SetColor("Color_4D278DE4", new Color(190.0f, 0.0f, 0.0f, 1.0f) * glow);
                }
            }
            else
            {
                explode.SetActive(true);
                rocket.color = new Color(rocket.color.r, rocket.color.g, rocket.color.b, 0f);
                engines.SetActive(false);
                death.SetActive(true);
            }

        } else if (flying == false)
        {

            if (temp > 0.1f)
            {
                temp -= BalanceScript.cooling * Time.deltaTime;
                Temperature.fillAmount = temp;
                    glow = temp * -2f;
                    glowMat.SetColor("Color_4D278DE4", new Color(190.0f, 0.0f, 0.0f, 1.0f) * glow);

            }
        }
    }

    public void StartConsumption()
    {
        flying = true;
    }

    public void StopConsumption()
    {
        flying = false;
    }
}
