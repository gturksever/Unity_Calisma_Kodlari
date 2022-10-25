using System.Collections;
using UnityEngine;

public class PublicMethodlarCoroutine : MonoBehaviour
{

    public IEnumerator Birincicont;  //de�i�ken t�r� gibi coroutine tan�mlad�k
    public int yas;
    void Start()
    {
        Birincicont = Denemem(yas);
        StartCoroutine(Birincicont); //coroutine start ile tetiklenmezse �al��maz
    }

    IEnumerator Denemem(int yas)    //coroutine tan�m�d�r 
    {
        while (true)
        {
            Debug.Log("1.Yazd�rma");
            yield return new WaitForSeconds(yas);
            yield return null; // bir frame bekler -kare bekler
            yield return new WaitForSeconds(yas);  //yas saniye bekle kodu
            yield return new WaitForFixedUpdate(); //fixeduptade fonksiyonunu bitmesini bekler
            Debug.Log("2.Yazd�rma");
            yield return new WaitForSeconds(yas); //yas saniye bekle kodu
        }

        //Burada kodlar�m�z

        //Burada bekleme zaman�

        //istenirse di�er kodlar
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
