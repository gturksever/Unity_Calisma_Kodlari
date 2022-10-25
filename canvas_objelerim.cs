using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class canvas_objelerim : MonoBehaviour
{
    private Text benimtext;
    private Image benimresim;
    void Start()
    {
        
        benimtext = GetComponentInChildren<Text>();
        benimtext.text = "selam";

        benimresim = GetComponentInChildren<Image>();
        benimresim.fillAmount = 0.5f;
        
    }

    
    void Update()
    {


    }
}
