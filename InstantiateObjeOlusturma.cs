using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObjeOlusturma : MonoBehaviour
{
    public GameObject ornekobjem;
    void Start()
    {
        Instantiate(ornekobjem); // prefabdaki objeyyi ayn� konumunda olusturur
        Instantiate(ornekobjem, transform); //olu�an objeyi ana objenin childi yapar
        Instantiate(ornekobjem, transform.position, Quaternion.identity); //olu�an objenin pozisyonunu ana objeye ayarlar
        Instantiate(ornekobjem, new Vector3(3f, 2f, 3f), transform.rotation); //istedi�imiz noktaya obje olusturur
        //Not: klonlad���n objenin kompanentlerine eri�ebilirsin!!!

    }

    
    void Update()
    {
        transform.Translate(Vector3.forward);
    }
}
