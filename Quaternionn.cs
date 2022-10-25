using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quaternionn : MonoBehaviour
{
    private Vector3 fark;
    public Transform hedef;
    

    void Update()
    {
        transform.rotation = Quaternion.identity; //objenin rotasyonunu resetler.
        transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward); //bir objeyi kendi ekseninde d�nd�rme
        transform.rotation = Quaternion.Euler(90, 0, 0); // s�rayla cismi d�nd�r�r 1 kere yapar
        transform.rotation = Quaternion.LookRotation(fark, Vector3.up); //cismi takip etmeyi quaternion ile yapmak
        transform.rotation = Quaternion.Inverse(hedef.rotation); //objeyi tam  tersi rotate eder(ayna gibi d���n)

    }
    
}
