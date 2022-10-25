using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeyakalama : MonoBehaviour
{
    GameObject[] cokluobje;

    public GameObject disaridan;
    SphereCollider kurem;
    Rigidbody ekleyecegim;
    void Start()
    {

        ekleyecegim = gameObject.AddComponent(typeof(Rigidbody)) as Rigidbody; //obebe bu �ekilde de comonent eklenebilir
        ekleyecegim.useGravity=false;        //ekledi�im companenti yakalam���m gibi i�lem yapabilirim.
        ekleyece�im = gameObject.AddComponent<Rigidbody>() as Rigidbody; // objeye companenet ekleme
        ekleyece�im.isKinematic = true;  //ekledi�im kompanenti yakalam���m gibi i�lem yapabilirim.

        if (gameObject.CompareTag("Dusman"))  //obje tag� sorgulama
        {
            Debug.Log("evet dogru");
        }
        else
        {
            Debug.Log("hay�r yanl��");
        }
      

        Camera cam = (Camera)FindObjectOfType(typeof(Camera));

        
        kurem = gameObject.GetComponent("SphereCollider") as SphereCollider; //direk component yakalar
        kurem.isTrigger = true;
        disaridan.GetComponent<GetComponenta>().Yas = 52;
        

        
        cokluobje= GameObject.FindGameObjectsWithTag("Player");
        foreach (var item in cokluobje)
        {
            item.GetComponent<GetComponenta>().Yas = 5;
        }
        
        benim = GameObject.FindWithTag("Player");      //objenin unity �zerindeki tag � ile yakalamak optimizasyon olarak daha verimli
        benim.GetComponent<GetComponenta>().Yas = 12;
        GameObject aramasonuc = transform.Find("a").gameObject; //buda obje yakalama
        
        benim = GameObject.Find("Ana"); //anay� bir game object de�i�kenine atarsak ve sonraki i�lemleri bu de�i�ken ile kullan�rsak  optimizasyon olumlu etkilenir.
        GameObject.Find("Ana").GetComponent<GetComponenta>().Yas = 19;   //bir objenin componentini yakalama i�lem kodu .Find komutu b�t�n sahnelerde arama yapar optimizasyonu k�t� etkiler!!!
        GameObject.Find("�ocuk").GetComponent<GetComponenta>().Yas = 16; //bir objenin componentini yakalama i�lem kodu
        
        
        
        



        






        
    }



}
