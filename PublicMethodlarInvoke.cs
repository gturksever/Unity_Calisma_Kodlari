using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicMethodlarInvoke : MonoBehaviour
{

    // Invoke
    public float wait;
    void Start()
    {
        //Invoke("yaziyaz", wait); //belli bir süre sonra çaðýrýlan fonksiyonu 1 kere çalýþtýrýr
        InvokeRepeating("yaziyaz", wait, 0.08f); // wait kadar bekleyip sonrasýnda fonksiyonu çalýþtýrýr fonksiyon çalýþtýktan sonra 0.8f bekleyip sürekli fonksiyonu çalýþtýrýr
    }
    void yaziyaz()
    {
        Debug.Log("ben fonksiyondan " + wait + " saniye sonra geliyorum");
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            CancelInvoke();             //invoke durdurur
        }

        if (IsInvoking("yaziyaz"))     //Invoke çalýþýyor mu kontrol fonksiyonu
        {
            Debug.Log("evet");
            
        }
        else
        {
            Debug.Log("hayýr");
        }
    }

}
