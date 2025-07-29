using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioVolumePanel : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixer;

    public void ChangeMasterVolume(float volume)
    {

        _mixer.audioMixer.SetFloat("MasterVolume", Mathf.Lerp(-80, 0, volume));
    }

    public void ChangeBackgroundVolume(float volume)
    {

        _mixer.audioMixer.SetFloat("BackgroundVolume", Mathf.Lerp(-80, 0, volume));
    }

    public void ChangeButtonsVolume(float volume)
    {

        _mixer.audioMixer.SetFloat("ButtonsVolume", Mathf.Lerp(-80, 0, volume));
    }
}
