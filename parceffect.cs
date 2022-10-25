using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parceffect : MonoBehaviour
{
    ParticleSystem parct;
    void Start()
    {
        parct = GetComponent<ParticleSystem>();
        parct.Stop();


    }
   

    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.S))
        {
             parct.Play();
             
        }
    }
}
