using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class EngineSounds : MonoBehaviour
{
    public AudioSource clip;
    public ParticleSystem engine;
    private float volumeValue = 0.4f;

    // Update is called once per frame
    void Update()
    {
        if (engine.isPlaying)
        {
            if(volumeValue < 1f)
            {
                volumeValue += 1f * Time.deltaTime;
                clip.pitch = volumeValue;
                clip.volume = volumeValue;
            }
        }else if(!engine.isPlaying)
        {
            if(volumeValue > 0.4f)
            {
                volumeValue -= 5f * Time.deltaTime;
                clip.pitch = volumeValue;
                clip.volume = volumeValue + 0.25f;
            }
        }
    }
}
