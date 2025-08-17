using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private string _volumeGroupName;

    private Slider _slider;
    private AudioMixerController _audioMixerController;

    private void Awake()
    {
        _audioMixerController = FindObjectOfType<AudioMixerController>();
        _slider = GetComponent<Slider>();
        _slider.onValueChanged.AddListener((value) => _audioMixerController.ChangeVolume(value, _volumeGroupName));
    }
}
