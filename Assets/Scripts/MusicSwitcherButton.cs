using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Button))]
public class MusicSwitcherButton : MonoBehaviour
{
    private Button _button;
    private bool _canSwitch = true;

    public AudioSource Source { get; private set; }

    private void Awake()
    {
        Source = GetComponent<AudioSource>();
        _button = GetComponent<Button>();
        _button.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        if (_canSwitch)
        {
            Source.Play();
        }
    }

    public void SetAvailableStatus(bool status)
    {
        _canSwitch = status;
    }
}

