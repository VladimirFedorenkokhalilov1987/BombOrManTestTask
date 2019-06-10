using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource MainTheme;
    public AudioSource SFX;

    public AudioClip Blow;
    public AudioClip Win;
    public AudioClip Loose;
    public AudioClip BonusPicUp;

    public void PlaySound(AudioClip name)
    {
            SFX.GetComponent<AudioSource>().clip = name;
            SFX.GetComponent<AudioSource>().Play();
    
        
    if(name== Win || name==Loose)
            MainTheme.Stop();
    }
    
}
