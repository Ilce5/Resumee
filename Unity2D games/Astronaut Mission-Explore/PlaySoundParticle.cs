using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class PlaySoundParticle : MonoBehaviour
{
    public ParticleSystem part1;
    public AudioSource clip1;
    private bool done = false;
    float timer = 0f;

    public void Update()
    {
        if (part1.isPlaying && done == false)
        {
            timer += Time.deltaTime;
            if (timer >= 5.5f)
            {
                clip1.Play();
                done = true;
            }
            
        }
        else if(!part1.isPlaying)
        {
            timer = 0f;
            done = false;
        }
    }
}
