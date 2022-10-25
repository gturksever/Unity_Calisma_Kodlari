using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemelFonksiyonlar : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake ile geldi");
        //proje �al���r �al��maz �al���r
    }

    private void OnEnable()
    {
        Debug.Log("Oneenable ile geldi");
        //obje aktifse �al���r
    }


    void Start()
    {
        Debug.Log("Start ile geldi");
    }

    // g�ncelleme fonksiyonlar�n�n s�ras�

    private void FixedUpdate()
    {
        Debug.Log("FixUpdate ile s�rekli geliyor");
        //  0.02 saniye (unity proje settings time dan �al��ma s�kl��� de�i�tirilebilir)
    }


    void Update()
    {
        Debug.Log("Update ile s�rekli geliyor");
        // 1 saniye
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate ile s�rekli geliyor");
        // di�er b�t�n update fonkisyonlar� bitince �al���r
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable ile s�rekli geliyor");
        // obje pasifse �al���r
    }
}
