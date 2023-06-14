using UnityEngine;
using UnityEngine.Audio;
public class KeepMusic : MonoBehaviour
{
    public AudioSource clip1;
    public AudioListener AudioListener;
    // Start is called before the first frame update
    void Start()
    {
        clip1.volume = BalanceScript.musicVolume;
        if (BalanceScript.sfxMusic == true)
        {
            AudioListener.volume = 1f;
            if (BalanceScript.musicAudio == true)
            {
                clip1.Play();
            }
            else
            {
                clip1.Pause();
            }
        }
        else
        {
            clip1.Pause();
            AudioListener.volume = 0f;
        }
    }
}
