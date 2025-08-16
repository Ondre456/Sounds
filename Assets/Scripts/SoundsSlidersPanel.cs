using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundsSlidersPanel : MonoBehaviour
{
    private const string MasterVolume = "MasterVolume";
    private const string BackgroundVolume = "BackgroundVolume";
    private const string ButtonsVolume = "ButtonsVolume";
    private const float MinVolume = -80;
    private const float MaxVolume = 0;

    [SerializeField] private Slider _masterVolumeSlider;
    [SerializeField] private Slider _backgroundVolumeSlider;
    [SerializeField] private Slider _buttonsVolumeSlider;
    [SerializeField] private AudioMixerGroup _mixer;

    private void Awake()
    {
        _masterVolumeSlider.onValueChanged.AddListener((value) => ChangeVolume(value, MasterVolume));
        _backgroundVolumeSlider.onValueChanged.AddListener((value) => ChangeVolume(value, BackgroundVolume));
        _buttonsVolumeSlider.onValueChanged.AddListener((value) => ChangeVolume(value, ButtonsVolume));
    }

    public void ChangeVolume(float volume, string volumeGroupName)
    {
        _mixer.audioMixer.SetFloat(volumeGroupName, Mathf.Lerp(MinVolume, MaxVolume, volume));
    }
}
