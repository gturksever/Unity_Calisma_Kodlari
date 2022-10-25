using System.Collections;
using UnityEngine;

public class PublicMethodlarCoroutine : MonoBehaviour
{

    public IEnumerator Birincicont;  //deðiþken türü gibi coroutine tanýmladýk
    public int yas;
    void Start()
    {
        Birincicont = Denemem(yas);
        StartCoroutine(Birincicont); //coroutine start ile tetiklenmezse çalýþmaz
    }

    IEnumerator Denemem(int yas)    //coroutine tanýmýdýr 
    {
        while (true)
        {
            Debug.Log("1.Yazdýrma");
            yield return new WaitForSeconds(yas);
            yield return null; // bir frame bekler -kare bekler
            yield return new WaitForSeconds(yas);  //yas saniye bekle kodu
            yield return new WaitForFixedUpdate(); //fixeduptade fonksiyonunu bitmesini bekler
            Debug.Log("2.Yazdýrma");
            yield return new WaitForSeconds(yas); //yas saniye bekle kodu
        }

        //Burada kodlarýmýz

        //Burada bekleme zamaný

        //istenirse diðer kodlar
    }
    private void Update()
    {
        if (Input.GetKeyDown("n"))
        {
            StopCoroutine(Birincicont);
        }
        if (Input.GetKeyDown("y"))
        {
            StartCoroutine(Birincicont);
        }
       
    }




}
