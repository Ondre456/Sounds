using UnityEngine;
using UnityEngine.Audio;

public class AudioVolumePanel : MonoBehaviour
{
    private const float MinVolume = -80;
    private const float MaxVolume = 0;

    [SerializeField] private AudioMixerGroup _mixer;

    public void ChangeVolume(float volume, string volumeGroupName)
    {
        _mixer.audioMixer.SetFloat(volumeGroupName, Mathf.Lerp(MinVolume, MaxVolume, volume));
    }
}
