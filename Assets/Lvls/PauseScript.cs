using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PauseScript : MonoBehaviour
{
    public bool PauseGame;
    public GameObject pauseGameMenu;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(PauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }        
    }

    public void Resume()
    {
        pauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
    }

    public void Pause()
    {
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public AudioMixer audioMixer;
/*    public Toggle toggle;*/

    public void Sound(bool enable)
    {
        /*AudioListener.pause = !AudioListener.pause;*/

        if (enable)
        {
            AudioListener.volume = 1f;
        }
        else
        {
            AudioListener.volume = 0f;
        }

/*        if(AudioListener.volume == 1f)
        {
            toggle.isOn = true;
        }
        else
        {
            toggle.isOn = false;
        }*/
    }
}
