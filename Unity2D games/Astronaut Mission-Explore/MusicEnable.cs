using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MusicEnable : MonoBehaviour
{
    public AudioSource clip1;
    public GameObject checkMark;
    public GameObject checkMark2;
    public Slider slider1;
    public Animator anim;
    public AudioListener AudioListener;
    public GameObject saveScript;

    void Start()
    {
        if(BalanceScript.playAnimation == 0)
        {
            anim.Play("Entry");
        }else if(BalanceScript.playAnimation == 1)
        {
            anim.Play("Fade");
            BalanceScript.playAnimation = 0;
            saveScript.GetComponent<BalanceScript>().Save();
        }
        else if(BalanceScript.playAnimation == 3)
        {
            anim.Play("Reverse PlayClick");
            BalanceScript.playAnimation = 0;
            saveScript.GetComponent<BalanceScript>().Save();
        }

        clip1.volume = BalanceScript.musicVolume;
        slider1.value = BalanceScript.musicVolume;
        if (BalanceScript.sfxMusic == true)
        {
            AudioListener.volume = 1f;
            checkMark2.SetActive(true);
        }
        else
        {
            clip1.Pause();
            AudioListener.volume = 0f;
            checkMark2.SetActive(false);
        }
        if (BalanceScript.musicAudio == true)
            {
                checkMark.SetActive(true);
                clip1.Play();
            }
            else
            {
                checkMark.SetActive(false);
                clip1.Pause();
            }
    }
    public void ChangeValueOfMusic()
    {
        if (BalanceScript.musicAudio == false)
        {
            checkMark.SetActive(true);
            clip1.Play();
            BalanceScript.musicAudio = true;
        }
        else if(BalanceScript.musicAudio == true)
        {
            checkMark.SetActive(false);
            clip1.Pause();
            BalanceScript.musicAudio = false;
        }
    }
    public void ChangeValueOfSfx()
    {
        if (BalanceScript.sfxMusic == true)
        {
            clip1.Pause();
            AudioListener.volume = 0f;
            checkMark2.SetActive(false);
            BalanceScript.sfxMusic = false;
        }
        else
        {
            AudioListener.volume = 1f;
            checkMark2.SetActive(true);
            BalanceScript.sfxMusic = true;
            if(BalanceScript.musicAudio == true)
            {
                clip1.Play();
            }
        }
    }
    public void VolumeChange()
    {
        BalanceScript.musicVolume = slider1.value;
        clip1.volume = slider1.value;
    }
}
