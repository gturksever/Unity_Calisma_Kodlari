using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicMethodlarInvoke : MonoBehaviour
{

    // Invoke
    public float wait;
    void Start()
    {
        //Invoke("yaziyaz", wait); //belli bir s�re sonra �a��r�lan fonksiyonu 1 kere �al��t�r�r
        InvokeRepeating("yaziyaz", wait, 0.08f); // wait kadar bekleyip sonras�nda fonksiyonu �al��t�r�r fonksiyon �al��t�ktan sonra 0.8f bekleyip s�rekli fonksiyonu �al��t�r�r
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

        if (IsInvoking("yaziyaz"))     //Invoke �al���yor mu kontrol fonksiyonu
        {
            Debug.Log("evet");
            
        }
        else
        {
            Debug.Log("hay�r");
        }
    }

}
