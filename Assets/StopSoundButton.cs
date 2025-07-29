using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class StopSoundButton : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixer;
    [SerializeField] private List<AudioSource> _buttonAudioSources;

    private bool _isOn = true;

    public void OnClick()
    {
        if (_isOn)
        {
            _mixer.audioMixer.SetFloat("MasterVolume", -80);

            foreach (AudioSource source in _buttonAudioSources)
            {
                source.Stop();
            }

            _isOn = false;
        }
        else
        {
            _mixer.audioMixer.SetFloat("MasterVolume", 0);
            _isOn = true;
        }
    }
}
