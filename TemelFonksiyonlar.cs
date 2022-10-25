using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemelFonksiyonlar : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake ile geldi");
        //proje çalýþýr çalýþmaz çalýþýr
    }

    private void OnEnable()
    {
        Debug.Log("Oneenable ile geldi");
        //obje aktifse çalýþýr
    }


    void Start()
    {
        Debug.Log("Start ile geldi");
    }

    // güncelleme fonksiyonlarýnýn sýrasý

    private void FixedUpdate()
    {
        Debug.Log("FixUpdate ile sürekli geliyor");
        //  0.02 saniye (unity proje settings time dan çalýþma sýklýðý deðiþtirilebilir)
    }


    void Update()
    {
        Debug.Log("Update ile sürekli geliyor");
        // 1 saniye
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate ile sürekli geliyor");
        // diðer bütün update fonkisyonlarý bitince çalýþýr
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable ile sürekli geliyor");
        // obje pasifse çalýþýr
    }
}
