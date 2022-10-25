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
        
        
        if (pozisyonum1 == pozisyonum2) //2 vektörün ayný olup olmadýðýný kontrol eder
        {
            Debug.Log("evet ayný");
        }
        else
        {
            Debug.Log("hayýr ayný deðil");
        }
    }

    
    void Update()
    {

        transform.Translate(new Vector3(2f, 2f, 3f) * Time.deltaTime); //saniyede x y ve z ekseninde kaç birim gideceði kodu x ekseni sol sað y ekseni yukarý aþaðý z ekseni ileri geriyi kontrol eder 

        Debug.Log(Vector3.SqrMagnitude(transform.position)); // vektörün kare uzunluðu
        Debug.Log(Vector3.Magnitude(transform.position)); //vektör uzunluðu hesaplama

    }
}
