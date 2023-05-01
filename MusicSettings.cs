using UnityEngine;
using UnityEngine.Audio;

public class MusicSettings : MonoBehaviour
{
    public AudioMixerGroup Mixer;

    public void ToggleMusic(bool enabled)
    {
        if(enabled)
            Mixer.audioMixer.SetFloat("MusicVolume", 0);
        else
            Mixer.audioMixer.SetFloat("MusicVolume", -80);
    }

    public void ChangeMusic(float volume)
    {
            Mixer.audioMixer.SetFloat("MasterVolume", Mathf.Lerp(-80, 0, volume));
    }

}
