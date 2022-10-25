using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObjeOlusturma : MonoBehaviour
{
    public GameObject ornekobjem;
    void Start()
    {
        Instantiate(ornekobjem); // prefabdaki objeyyi ayný konumunda olusturur
        Instantiate(ornekobjem, transform); //oluþan objeyi ana objenin childi yapar
        Instantiate(ornekobjem, transform.position, Quaternion.identity); //oluþan objenin pozisyonunu ana objeye ayarlar
        Instantiate(ornekobjem, new Vector3(3f, 2f, 3f), transform.rotation); //istediðimiz noktaya obje olusturur
        //Not: klonladýðýn objenin kompanentlerine eriþebilirsin!!!

    }

    
    void Update()
    {
        transform.Translate(Vector3.forward);
    }
}
