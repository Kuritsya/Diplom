using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsClick : MonoBehaviour
{
    public void NextLvlClick()
    {
        if (SceneManager.GetActiveScene().name == "Lvl_0")
        {
            SceneManager.LoadScene("Lvl_1");
        }
        else if(SceneManager.GetActiveScene().name == "Lvl_1")
        {
            SceneManager.LoadScene("Lvl_2");
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_2")
        {
            SceneManager.LoadScene("Lvl_3");
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_3")
        {
            SceneManager.LoadScene("Lvl_4");
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_4")
        {
            SceneManager.LoadScene("Lvl_5");
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_5")
        {
            SceneManager.LoadScene("Lvl_6");
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_6")
        {
            SceneManager.LoadScene("Lvl_7");
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_7")
        {
            SceneManager.LoadScene("Lvl_8");
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_8")
        {
            SceneManager.LoadScene("Lvl_9");
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_9")
        {
            SceneManager.LoadScene("Lvl_10");
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_10")
        {
            SceneManager.LoadScene("Lvl_11");
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_11")
        {
            SceneManager.LoadScene("Lvl_12");
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_12")
        {
            SceneManager.LoadScene("Lvl_13");
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_13")
        {
            SceneManager.LoadScene("Lvl_14");
        }
        else
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
