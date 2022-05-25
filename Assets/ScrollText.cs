using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ScrollText : MonoBehaviour
{
    [SerializeField] RectTransform txtRt;
    [SerializeField] RectTransform contentRt;

    // Update is called once per frame
    void Update()
    {
        var size = contentRt.sizeDelta;
        size.y = txtRt.sizeDelta.y;
        contentRt.sizeDelta = size;        
    }
}
