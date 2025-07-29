using UnityEngine;

public class ButtonOnMusic : MonoBehaviour
{
    [SerializeField] private AudioSource _source;
    
    public void OnClick()
    {
        _source.Play();
    }
}
