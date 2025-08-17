using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class StopSoundButton : MonoBehaviour
{
    private AudioMixerController _mixerController;
    private Button _button;

    private void Awake()
    {
        _mixerController = FindObjectOfType<AudioMixerController>();
        _button = GetComponent<Button>();
        _button.onClick.AddListener(OnClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnClick);
    }

    private void OnClick()
    {
        _mixerController.SwitchMusic();
    }
}
