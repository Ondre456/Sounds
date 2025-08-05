using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class OnMusicButton : MonoBehaviour
{
    private AudioSource _source;

    private void Awake()
    {
        _source = GetComponent<AudioSource>();
    }

    public void OnClick()
    {
        _source.Play();
    }
}

