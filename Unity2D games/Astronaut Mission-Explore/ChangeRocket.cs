using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class ChangeRocket : MonoBehaviour
{
    public Sprite Rtier1;
    public Sprite Rtier2;
    public Sprite Rtier3;
    public Sprite Rtier4;
    public Sprite Rtier5;
    public Sprite Rtier6;
    public Sprite Rtier7;
    public Sprite Rtier8;
    public Sprite Rtier9;
    public Sprite Rtier10;

    public GameObject Particle1;
    public GameObject Particle2;
    public GameObject Particle3;
    public GameObject Particle4;
    public GameObject Particle5;
    public GameObject Particle6;
    public GameObject Particle7;
    public GameObject Particle8;
    public GameObject Particle9;
    public GameObject Particle10;
    public Image Rocket;
    public Image IngameRocket;

    public Material glowMat;
    public Texture2D mRenderer;
    public Texture2D mRenderer2;
    public Texture2D mRenderer3;
    public Texture2D mRenderer4;
    public Texture2D mRenderer5;
    public Texture2D mRenderer6;
    public Texture2D mRenderer7;
    public Texture2D mRenderer8;
    public Texture2D mRenderer9;
    public Texture2D mRenderer10;

    public GameObject rocketShards;

    public Image Rocket2;
    public Image Rocket3;
    public Image Rocket4;
    public Image Rocket5;
    public Image Rocket6;
    public Image Rocket7;
    public Image Rocket8;
    public Image Rocket9;
    public Image Rocket10;

    public AudioSource confirmed;
    public AudioSource notconfirmed;

    void Start()
    {
        if (BalanceScript.rcheck2 == true)
        {
            Rocket2.color = new Color32(255, 255, 255, 255);
        }
        if (BalanceScript.rcheck3 == true)
        {
            Rocket3.color = new Color32(255, 255, 255, 255);
        }
        if (BalanceScript.rcheck4 == true)
        {
            Rocket4.color = new Color32(255, 255, 255, 255);
        }
        if (BalanceScript.rcheck5 == true)
        {
            Rocket5.color = new Color32(255, 255, 255, 255);
        }
        if (BalanceScript.rcheck6 == true)
        {
            Rocket6.color = new Color32(255, 255, 255, 255);
        }
        if (BalanceScript.rcheck7 == true)
        {
            Rocket7.color = new Color32(255, 255, 255, 255);
        }
        if (BalanceScript.rcheck8 == true)
        {
            Rocket8.color = new Color32(255, 255, 255, 255);
        }
        if (BalanceScript.rcheck9 == true)
        {
            Rocket9.color = new Color32(255, 255, 255, 255);
        }
        if (BalanceScript.rcheck10 == true)
        {
            Rocket10.color = new Color32(255, 255, 255, 255);
        }
        ParticlesOff();
        if(BalanceScript.rEngine2 == true)
        {
            Particle2.SetActive(true);
            Rocket.sprite = Rtier2;
            IngameRocket.sprite = Rtier2;
            glowMat.SetTexture("Texture2D_A124CD01", mRenderer2);
        }
        else if (BalanceScript.rEngine3 == true)
        {
            Particle3.SetActive(true);
            Rocket.sprite = Rtier3;
            IngameRocket.sprite = Rtier3;
            glowMat.SetTexture("Texture2D_A124CD01", mRenderer3);
        }
        else if (BalanceScript.rEngine4 == true)
        {
            Particle4.SetActive(true);
            Rocket.sprite = Rtier4;
            IngameRocket.sprite = Rtier4;
            glowMat.SetTexture("Texture2D_A124CD01", mRenderer4);
        }
        else if (BalanceScript.rEngine5 == true)
        {
            Particle5.SetActive(true);
            Rocket.sprite = Rtier5;
            IngameRocket.sprite = Rtier5;
            glowMat.SetTexture("Texture2D_A124CD01", mRenderer5);
        }
        else if (BalanceScript.rEngine6 == true)
        {
            Particle6.SetActive(true);
            Rocket.sprite = Rtier6;
            IngameRocket.sprite = Rtier6;
            glowMat.SetTexture("Texture2D_A124CD01", mRenderer6);
        }
        else if (BalanceScript.rEngine7 == true)
        {
            Particle7.SetActive(true);
            Rocket.sprite = Rtier7;
            IngameRocket.sprite = Rtier7;
            glowMat.SetTexture("Texture2D_A124CD01", mRenderer7);
        }
        else if (BalanceScript.rEngine8 == true)
        {
            Particle8.SetActive(true);
            Rocket.sprite = Rtier8;
            IngameRocket.sprite = Rtier8;
            glowMat.SetTexture("Texture2D_A124CD01", mRenderer8);
        }
        else if (BalanceScript.rEngine9 == true)
        {
            Particle9.SetActive(true);
            Rocket.sprite = Rtier9;
            IngameRocket.sprite = Rtier9;
            glowMat.SetTexture("Texture2D_A124CD01", mRenderer9);
        }
        else if (BalanceScript.rEngine10 == true)
        {
            Particle10.SetActive(true);
            Rocket.sprite = Rtier10;
            IngameRocket.sprite = Rtier10;
            glowMat.SetTexture("Texture2D_A124CD01", mRenderer10);
            rocketShards.SetActive(true);
        }
        else
        {
            Particle1.SetActive(true);
            Rocket.sprite = Rtier1;
            IngameRocket.sprite = Rtier1;
            glowMat.SetTexture("Texture2D_A124CD01", mRenderer);
        }
    }
    public void Tier1()
    {
        confirmed.Play();
        Rocket.sprite = Rtier1;
        IngameRocket.sprite = Rtier1;
        ParticlesOff();
        Particle1.SetActive(true);
        glowMat.SetTexture("Texture2D_A124CD01", mRenderer);
        ForgetRocket();
        BalanceScript.rEngine1 = true;
    }
    public void Tier2()
    {
        if (BalanceScript.rcheck2 == true)
        {
            Rocket.sprite = Rtier2;
            IngameRocket.sprite = Rtier2;
            ParticlesOff();
            Particle2.SetActive(true);
            glowMat.SetTexture("Texture2D_A124CD01", mRenderer2); 
            confirmed.Play();
            ForgetRocket();
            BalanceScript.rEngine2 = true;
        }
        else
        {
            notconfirmed.Play();
        }
    }
    public void Tier3()
    {
        if (BalanceScript.rcheck3 == true)
        {
            Rocket.sprite = Rtier3;
            IngameRocket.sprite = Rtier3;
            ParticlesOff();
            Particle3.SetActive(true);
            glowMat.SetTexture("Texture2D_A124CD01", mRenderer3);
            confirmed.Play();
            ForgetRocket();
            BalanceScript.rEngine3 = true;
        }
        else
        {
            notconfirmed.Play();
        }
    }
    public void Tier4()
    {
        if (BalanceScript.rcheck4 == true)
        {
            Rocket.sprite = Rtier4;
            IngameRocket.sprite = Rtier4;
            ParticlesOff();
            Particle4.SetActive(true);
            glowMat.SetTexture("Texture2D_A124CD01", mRenderer4);
            confirmed.Play();
            ForgetRocket();
            BalanceScript.rEngine4 = true;
        }
        else
        {
            notconfirmed.Play();
        }
    }
    public void Tier5()
    {
        if (BalanceScript.rcheck5 == true)
        {
            Rocket.sprite = Rtier5;
            IngameRocket.sprite = Rtier5;
            ParticlesOff();
            Particle5.SetActive(true);
            glowMat.SetTexture("Texture2D_A124CD01", mRenderer5);
            confirmed.Play();
            ForgetRocket();
            BalanceScript.rEngine5 = true;
        }
        else
        {
            notconfirmed.Play();
        }
    }
    public void Tier6()
    {
        if (BalanceScript.rcheck6 == true)
        {
            Rocket.sprite = Rtier6;
            IngameRocket.sprite = Rtier6;
            ParticlesOff();
            Particle6.SetActive(true);
            glowMat.SetTexture("Texture2D_A124CD01", mRenderer6);
            confirmed.Play();
            ForgetRocket();
            BalanceScript.rEngine6 = true;
        }
        else
        {
            notconfirmed.Play();
        }
    }
    public void Tier7()
    {
        if (BalanceScript.rcheck7 == true)
        {
            Rocket.sprite = Rtier7;
            IngameRocket.sprite = Rtier7;
            ParticlesOff();
            Particle7.SetActive(true);
            glowMat.SetTexture("Texture2D_A124CD01", mRenderer7);
            confirmed.Play();
            ForgetRocket();
            BalanceScript.rEngine7 = true;
        }
        else
        {
            notconfirmed.Play();
        }
    }
    public void Tier8()
    {
        if (BalanceScript.rcheck8 == true)
        {
            Rocket.sprite = Rtier8;
            IngameRocket.sprite = Rtier8;
            ParticlesOff();
            Particle8.SetActive(true);
            glowMat.SetTexture("Texture2D_A124CD01", mRenderer8);
            confirmed.Play();
            ForgetRocket();
            BalanceScript.rEngine8 = true;
        }
        else
        {
            notconfirmed.Play();
        }
    }
    public void Tier9()
    {
        if (BalanceScript.rcheck9 == true)
        {
            Rocket.sprite = Rtier9;
            IngameRocket.sprite = Rtier9;
            ParticlesOff();
            Particle9.SetActive(true);
            glowMat.SetTexture("Texture2D_A124CD01", mRenderer9);
            confirmed.Play();
            ForgetRocket();
            BalanceScript.rEngine9 = true;
        }
        else
        {
            notconfirmed.Play();
        }
    }
    public void Tier10()
    {
        if (BalanceScript.rcheck10 == true)
        {
            Rocket.sprite = Rtier10;
            IngameRocket.sprite = Rtier10;
            ParticlesOff();
            Particle10.SetActive(true);
            glowMat.SetTexture("Texture2D_A124CD01", mRenderer10);
            confirmed.Play();
            rocketShards.SetActive(true);
            ForgetRocket();
            BalanceScript.rEngine10 = true;
        }
        else
        {
            notconfirmed.Play();
        }
    }
    void ParticlesOff()
    {
        Particle1.SetActive(false);
        Particle2.SetActive(false);
        Particle3.SetActive(false);
        Particle4.SetActive(false);
        Particle5.SetActive(false);
        Particle6.SetActive(false);
        Particle7.SetActive(false);
        Particle8.SetActive(false);
        Particle9.SetActive(false);
        Particle10.SetActive(false);
        rocketShards.SetActive(false);
    }
    void ForgetRocket()
    {
        BalanceScript.rEngine1 = false;
        BalanceScript.rEngine2 = false;
        BalanceScript.rEngine3 = false;
        BalanceScript.rEngine4 = false;
        BalanceScript.rEngine5 = false;
        BalanceScript.rEngine6 = false;
        BalanceScript.rEngine7 = false;
        BalanceScript.rEngine8 = false;
        BalanceScript.rEngine9 = false;
        BalanceScript.rEngine10 = false;
    }
}
