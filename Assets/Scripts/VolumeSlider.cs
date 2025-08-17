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
        _slider.onValueChanged.AddListener(ChangeValue);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(ChangeValue);
    }

    private void ChangeValue(float value)
    {
        _audioMixerController.ChangeVolume(value, _volumeGroupName);
    }
}
