using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class LvlSettings : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void Sound()
    {
        AudioListener.pause = !AudioListener.pause;
    }

    public void ExitLvl()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
