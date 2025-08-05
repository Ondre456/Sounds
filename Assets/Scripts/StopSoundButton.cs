using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class StopSoundButton : MonoBehaviour
{
    private const float MinVolume = -80;
    private const float MaxVolume = 0;

    [SerializeField] private AudioMixerGroup _mixer;

    private List<AudioSource> _buttonAudioSources;
    private bool _isOn = true;

    public void OnClick()
    {
        if (_isOn)
        {
            _mixer.audioMixer.SetFloat("MasterVolume", MinVolume);

            foreach (AudioSource source in _buttonAudioSources)
            {
                source.Stop();
            }

            _isOn = false;
        }
        else
        {
            _mixer.audioMixer.SetFloat("MasterVolume", MaxVolume);
            _isOn = true;
        }
    }
}
