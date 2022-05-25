using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play_0()
    {
        SceneManager.LoadScene("Lvl_0");
    }
    public void Play_1()
    {
        SceneManager.LoadScene("Lvl_1");
    }
    public void Play_2()
    {
        SceneManager.LoadScene("Lvl_2");
    }
    public void Play_3()
    {
        SceneManager.LoadScene("Lvl_3");
    }
    public void Play_4()
    {
        SceneManager.LoadScene("Lvl_4");
    }
    public void Play_5()
    {
        SceneManager.LoadScene("Lvl_5");
    }
    public void Play_6()
    {
        SceneManager.LoadScene("Lvl_6");
    }
    public void Play_7()
    {
        SceneManager.LoadScene("Lvl_7");
    }
    public void Play_8()
    {
        SceneManager.LoadScene("Lvl_8");
    }
    public void Play_9()
    {
        SceneManager.LoadScene("Lvl_9");
    }
    public void Play_10()
    {
        SceneManager.LoadScene("Lvl_10");
    }
    public void Play_11()
    {
        SceneManager.LoadScene("Lvl_11");
    }
    public void Play_12()
    {
        SceneManager.LoadScene("Lvl_12");
    }
    public void Play_13()
    {
        SceneManager.LoadScene("Lvl_13");
    }
    public void Play_14()
    {
        SceneManager.LoadScene("Lvl_14");
    }

    public void ExitGame()
    {
        Debug.Log("Игра закрылась");
        Application.Quit();
    }
}
