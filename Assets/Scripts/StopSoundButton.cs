using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class StopSoundButton : MonoBehaviour
{
    private const float MinVolume = -80;
    private const string MasterVolume = "MasterVolume";

    [SerializeField] private AudioMixerGroup _mixer;
    [SerializeField] private MusicSwitcherButton[] _musicSwitcherButtons;

    private bool _isOn = true;
    private float _lastMusicVolume = 0;

    public void OnClick()
    {
        if (_isOn)
        {
             _mixer.audioMixer.GetFloat(MasterVolume, out _lastMusicVolume);
            _mixer.audioMixer.SetFloat(MasterVolume, MinVolume);

            _isOn = false;

            foreach (MusicSwitcherButton button in _musicSwitcherButtons)
            {
                button.SetAvailableStatus(_isOn);
                button.Source.Stop();
            }
        }
        else
        {
            _mixer.audioMixer.SetFloat(MasterVolume, _lastMusicVolume);
            _isOn = true;

            foreach (MusicSwitcherButton button in _musicSwitcherButtons)
            {
                button.SetAvailableStatus(_isOn);
                button.Source.Stop();
            }
        }
    }
}
