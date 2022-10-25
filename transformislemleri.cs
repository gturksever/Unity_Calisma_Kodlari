using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformislemleri : MonoBehaviour
{
    Vector3 pozisyonum1;
    Vector3 pozisyonum2;
    
    void Start()
    {
        Debug.Log(transform.position);
        Debug.Log(transform.rotation);
        Debug.Log(transform.localScale);
        pozisyonum1 = new Vector3(1f, 2.1f, 1f);
        pozisyonum2 = new Vector3(2.1f, 1f, 1f);

        

        Debug.Log((pozisyonum1.ToString()).GetType());
        
        
        if (pozisyonum1 == pozisyonum2) //2 vekt�r�n ayn� olup olmad���n� kontrol eder
        {
            Debug.Log("evet ayn�");
        }
        else
        {
            Debug.Log("hay�r ayn� de�il");
        }
    }

    
    void Update()
    {

        transform.Translate(new Vector3(2f, 2f, 3f) * Time.deltaTime); //saniyede x y ve z ekseninde ka� birim gidece�i kodu x ekseni sol sa� y ekseni yukar� a�a�� z ekseni ileri geriyi kontrol eder 

        Debug.Log(Vector3.SqrMagnitude(transform.position)); // vekt�r�n kare uzunlu�u
        Debug.Log(Vector3.Magnitude(transform.position)); //vekt�r uzunlu�u hesaplama

    }
}
