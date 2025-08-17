using UnityEngine;
using UnityEngine.Audio;

public class AudioMixerController : MonoBehaviour
{
    private const string MasterVolume = "MasterVolume";
    private const string BackgroundVolume = "BackgroundVolume";
    private const string ButtonsVolume = "ButtonsVolume";
    private const float MinVolume = -80;
    private const float MaxVolume = 0;

    private AudioMixer _audioMixer;
    private AudioMixerGroup _mixerGroup;
    private bool _isOn = true;
    private float _lastMusicVolume = 0;
    private MusicSwitcherButton[] _musicSwitcherButtons;

    private void Awake()
    {
        _audioMixer = Resources.Load<AudioMixer>("AudioMixer");
        var groups = _audioMixer.FindMatchingGroups("Master");
        
        if (groups.Length > 0)
        {
            _mixerGroup = groups[0];
        }

        _musicSwitcherButtons = FindObjectsOfType<MusicSwitcherButton>();
    }

    public void ChangeVolume(float volume, string volumeGroupName)
    {
        _mixerGroup.audioMixer.SetFloat(volumeGroupName, Mathf.Lerp(MinVolume, MaxVolume, volume));
    }

    public void SwitchMusic()
    {
        if (_isOn)
        {
            _mixerGroup.audioMixer.GetFloat(MasterVolume, out _lastMusicVolume);
            _mixerGroup.audioMixer.SetFloat(MasterVolume, MinVolume);

            _isOn = false;

            OffAllButtonsSounds();
        }
        else
        {
            _mixerGroup.audioMixer.SetFloat(MasterVolume, _lastMusicVolume);
            _isOn = true;

            OffAllButtonsSounds();
        }
    }

    private void OffAllButtonsSounds()
    {
        foreach (MusicSwitcherButton button in _musicSwitcherButtons)
        {
            button.SetAvailableStatus(_isOn);
            button.Source.Stop();
        }
    }
}
