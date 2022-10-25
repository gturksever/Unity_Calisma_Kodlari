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
        aramasonuc.name = "ben degistim";                       //yakalanýlan objeye iþlem yapabiliriz


        for (int i = 0; i < transform.childCount; i++) // bu objenin cocuk sayýsýný verir ve buna göre cocuklar için for ile iþlem yapabiliriz
        {
            if (i == 1)
            {
                transform.GetChild(i).GetComponent<SphereCollider>().enabled = false;
            }
            if (transform.GetChild(i).name=="aranacakisim") //child ismine göre arama yapýp o isimdeki cocuða iþlem yapabiliriz.
            {
                //iþlemler
            }
        }
        
        hedef.transform.SetParent(hedef2,false); // hedef objesini hedef 2 nin child ý yapar. false ise mevcut pozisyonu bozma demek
    }

    
    
    
    
    void Update()
    {
        hedef2.transform.LookAt(hedef); // hedef2 hedefe sürekli bakar takip eder
        transform.position = Vector3.Lerp(hedef.position, hedef2.position,(Time.time - baslangiczamani) * .2f); //lerp komutu bir noktadan diðer noktaya rota çizer transform.position ile o rotayý takip ettirdik.
        transform.position = new Vector3(0.2f, 0.3f, 0.5f); //objem benim belirtmiþ olduðum kordinata ýþýnlanýr.
        transform.position = new Vector3(transform.position.x, 6f, transform.position.y); // belirli kordinatlarý sabit tutup istenileni deðiþtirmek.
        transform.Rotate(new Vector3(1f, 2f, 3f),Space.World); //obje döndürme
        hedef.Rotate(1f, 2f, 3f);                    // yakalanýlan transform kompanenti böylede çalýþtýrýlabilir
        
        transform.Translate(new Vector3(-3f, 0f, 0f) * Time.deltaTime);
        float f1 = Vector3.Distance(hedef.position, transform.position);  //distance aradaki mesafeyi hesaplar
        Debug.Log("aradaki mesafe:" + f1);
        

     }   
        
}        
        






    

    
    
