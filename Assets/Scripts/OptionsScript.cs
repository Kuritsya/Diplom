using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsScript : MonoBehaviour
{
    public AudioSource audio;
    public AudioMixer audioMixer;
    public Slider slider;

    public string saveSettings;

    public string sliderTag;
    public string screenTag;

    public float volume;

    bool isFullScreen;

    public void Awake()
    {
        if (PlayerPrefs.HasKey(this.saveSettings))
        {
            //this.isFullScreen = PlayerPrefs.GetInt(this.saveSettings);
            this.volume = PlayerPrefs.GetFloat(this.saveSettings);
            this.audio.volume = this.volume;

            GameObject sliderObj = GameObject.FindWithTag(this.sliderTag);
            if (sliderObj != null)
            {
                this.slider = sliderObj.GetComponent<Slider>();
                this.volume = slider.value;

                if (this.audio.volume != this.volume)
                {
                    PlayerPrefs.SetFloat(this.saveSettings, this.volume);
                    AudioListener.volume = 0f;
                }
                else
                {
                    this.volume = 0.5f;
                    PlayerPrefs.SetFloat(this.saveSettings, this.volume);
                    this.audio.volume = this.volume;
                    this.isFullScreen = true;
                    AudioListener.volume = 1f;
                }
            }
        }
    }

    public void LateUpdate()
    {
        GameObject sliderObj = GameObject.FindWithTag(this.sliderTag);
        if (sliderObj != null)
        {
            this.slider = sliderObj.GetComponent<Slider>();
            this.volume = slider.value;

            if (this.audio.volume != this.volume)
            {
                PlayerPrefs.SetFloat(this.saveSettings, this.volume);
            }
        }
    }
}
