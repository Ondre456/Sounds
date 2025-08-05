using UnityEngine;

public class VolumeSoundSlider : MonoBehaviour
{
    private const string SoundPanelTab = "GameSoundPanel";

    [SerializeField] private string _volumeGroupName;

    private AudioVolumePanel _volumePanel;

    private void Awake()
    {
        GameObject obj = GameObject.FindWithTag(SoundPanelTab);

        if (obj != null)
        {
            _volumePanel = obj.GetComponent<AudioVolumePanel>();
        }
    }

    public void OnValueChanged(float value)
    {
        _volumePanel.ChangeVolume(value, _volumeGroupName);
    }
}
