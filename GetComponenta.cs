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
        //transform.Find("�ocuk").GetComponent<AudioSource>().mute = true; //alt �ocuklar� bu �ekilde de bulabilirsin.

        /* alt �ocuklar�n elemanlar�n� yakalar
         * 
        GetComponentInChildren<AudioSource>().mute = true;
        GetComponentInChildren<CapsuleCollider>().enabled = false;
        */
        //GetComponentsInChildren<AudioSource>().mute = true;
        //GetComponentsInChildren<CapsuleCollider>().enabled = false;


        /* �stteki ait oldu�u aile elemanlar�n� yakalar
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
