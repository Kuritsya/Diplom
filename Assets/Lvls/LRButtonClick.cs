using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LRButtonClick : MonoBehaviour
{
    public GameObject scrView1;
    public GameObject scrView2;
    public GameObject scrView3;

    public void LeftButtonClick()
    {
        if (scrView1.activeSelf == true)
        {
            scrView1.SetActive(false);
            scrView3.SetActive(true);
        }
        else if (scrView2.activeSelf == true)
        {
            scrView2.SetActive(false);
            scrView1.SetActive(true);
        }
        else
        {
            scrView3.SetActive(false);
            scrView2.SetActive(true);
        }
    }

    public void RightButtonClick()
    {
        if (scrView1.activeSelf == true)
        {
            scrView1.SetActive(false);
            scrView2.SetActive(true);
        }
        else if (scrView2.activeSelf == true)
        {
            scrView2.SetActive(false);
            scrView3.SetActive(true);
        }
        else
        {
            scrView3.SetActive(false);
            scrView1.SetActive(true);
        }
    }
}
