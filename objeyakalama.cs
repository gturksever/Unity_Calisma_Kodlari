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

        ekleyecegim = gameObject.AddComponent(typeof(Rigidbody)) as Rigidbody; //obebe bu þekilde de comonent eklenebilir
        ekleyecegim.useGravity=false;        //eklediðim companenti yakalamýþým gibi iþlem yapabilirim.
        ekleyeceðim = gameObject.AddComponent<Rigidbody>() as Rigidbody; // objeye companenet ekleme
        ekleyeceðim.isKinematic = true;  //eklediðim kompanenti yakalamýþým gibi iþlem yapabilirim.

        if (gameObject.CompareTag("Dusman"))  //obje tagý sorgulama
        {
            Debug.Log("evet dogru");
        }
        else
        {
            Debug.Log("hayýr yanlýþ");
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
        
        benim = GameObject.FindWithTag("Player");      //objenin unity üzerindeki tag ý ile yakalamak optimizasyon olarak daha verimli
        benim.GetComponent<GetComponenta>().Yas = 12;
        GameObject aramasonuc = transform.Find("a").gameObject; //buda obje yakalama
        
        benim = GameObject.Find("Ana"); //anayý bir game object deðiþkenine atarsak ve sonraki iþlemleri bu deðiþken ile kullanýrsak  optimizasyon olumlu etkilenir.
        GameObject.Find("Ana").GetComponent<GetComponenta>().Yas = 19;   //bir objenin componentini yakalama iþlem kodu .Find komutu bütün sahnelerde arama yapar optimizasyonu kötü etkiler!!!
        GameObject.Find("çocuk").GetComponent<GetComponenta>().Yas = 16; //bir objenin componentini yakalama iþlem kodu
        
        
        
        



        






        
    }



}
