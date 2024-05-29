using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AudioController : MonoBehaviour
{
    public AudioSource _musicSFX;

    public Sprite _musicOff;
    public Sprite _musicOn;

    public Image _musicButton;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            _musicSFX.volume = PlayerPrefs.GetFloat("MusicVolume");
        }
    }

    private void Start()
    {
        if (_musicSFX.volume >= 0.1f)
        {
            _musicButton.GetComponent<Image>().sprite = _musicOn;
        }
        else
        {
            _musicButton.GetComponent<Image>().sprite = _musicOff;
        }
    }

    public void OnClickMusicButton()
    {
        if (_musicSFX.volume >= 0.1f)
        {
            _musicSFX.volume = 0;
            _musicButton.GetComponent<Image>().sprite = _musicOff;
        }
        else
        {
            _musicSFX.volume = 0.5f;
            _musicButton.GetComponent<Image>().sprite = _musicOn;
        }

        PlayerPrefs.SetFloat("MusicVolume", _musicSFX.volume);
    }

}
