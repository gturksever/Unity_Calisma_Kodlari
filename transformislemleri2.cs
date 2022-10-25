using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformislemleri2 : MonoBehaviour
{
   
    //static methodlar

    public Transform hedef;
    public Transform hedef2;
    GameObject obje;
    private float baslangiczamani;
    void Start()
    {
        GameObject aramasonuc = transform.Find("a").gameObject; //obje yakalama
        aramasonuc.name = "ben degistim";                       //yakalan�lan objeye i�lem yapabiliriz


        for (int i = 0; i < transform.childCount; i++) // bu objenin cocuk say�s�n� verir ve buna g�re cocuklar i�in for ile i�lem yapabiliriz
        {
            if (i == 1)
            {
                transform.GetChild(i).GetComponent<SphereCollider>().enabled = false;
            }
            if (transform.GetChild(i).name=="aranacakisim") //child ismine g�re arama yap�p o isimdeki cocu�a i�lem yapabiliriz.
            {
                //i�lemler
            }
        }
        
        hedef.transform.SetParent(hedef2,false); // hedef objesini hedef 2 nin child � yapar. false ise mevcut pozisyonu bozma demek
    }

    
    
    
    
    void Update()
    {
        hedef2.transform.LookAt(hedef); // hedef2 hedefe s�rekli bakar takip eder
        transform.position = Vector3.Lerp(hedef.position, hedef2.position,(Time.time - baslangiczamani) * .2f); //lerp komutu bir noktadan di�er noktaya rota �izer transform.position ile o rotay� takip ettirdik.
        transform.position = new Vector3(0.2f, 0.3f, 0.5f); //objem benim belirtmi� oldu�um kordinata ���nlan�r.
        transform.position = new Vector3(transform.position.x, 6f, transform.position.y); // belirli kordinatlar� sabit tutup istenileni de�i�tirmek.
        transform.Rotate(new Vector3(1f, 2f, 3f),Space.World); //obje d�nd�rme
        hedef.Rotate(1f, 2f, 3f);                    // yakalan�lan transform kompanenti b�ylede �al��t�r�labilir
        
        transform.Translate(new Vector3(-3f, 0f, 0f) * Time.deltaTime);
        float f1 = Vector3.Distance(hedef.position, transform.position);  //distance aradaki mesafeyi hesaplar
        Debug.Log("aradaki mesafe:" + f1);
        

     }   
        
}        
        






    

    
    
