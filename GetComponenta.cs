using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponenta : MonoBehaviour
{

    public int Yas;
    SphereCollider kurem;
    SphereCollider[] kurelerim;
    
    void Start()
    {
        //transform.Find("çocuk").GetComponent<AudioSource>().mute = true; //alt çocuklarý bu þekilde de bulabilirsin.

        /* alt çocuklarýn elemanlarýný yakalar
         * 
        GetComponentInChildren<AudioSource>().mute = true;
        GetComponentInChildren<CapsuleCollider>().enabled = false;
        */
        //GetComponentsInChildren<AudioSource>().mute = true;
        //GetComponentsInChildren<CapsuleCollider>().enabled = false;


        /* üstteki ait olduðu aile elemanlarýný yakalar
         * 
        GetComponentInParent<AudioSource>().mute = true;
        GetComponentInParent<Rigidbody>().mass = 3;
        */






        /*  SphereCollider[] kurelerim = GetComponents<SphereCollider>();
        kurem = GetComponent<SphereCollider>();
        kurem.enabled = false;
        kurem.isTrigger = true;
        kurem.radius = 7;

        for(int i = 0;i< kurelerim.Length; i++)
        {
            kurelerim[i].isTrigger = true;
            kurelerim[i].isTrigger = true;
        }*/
    }

    
    
}
