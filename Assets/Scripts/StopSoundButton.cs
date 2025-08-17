using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class StopSoundButton : MonoBehaviour
{
    AudioMixerController _mixerController;
    private Button _button;

    private void Awake()
    {
        _mixerController = FindObjectOfType<AudioMixerController>();
        _button = GetComponent<Button>();
        _button.onClick.AddListener(() => _mixerController.SwitchMusic());
    }
}
