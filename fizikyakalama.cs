using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fizikyakalama : MonoBehaviour
{
    //rigidbody �arp��ma yakalama

    //rigidbody �arp��ma yakalaman�n �al��mas� i�in �arpt��� nesnenin rigidbody componentine sahip olmas�na gerek yoktur!!!
    
    private void OnCollisionEnter(Collision collision) //rigidbody ilk etkile�im an� funct
    {
        if (collision.gameObject.name=="sari")           //carp��t��� nesneyi ismi ile yakalama
        {
            Debug.Log("etkile�im var");
        }
    }
    
    private void OnCollisionStay(Collision collision)    //rigidbody etkile�im devam ettikce s�rd�rme funct
    {
        Debug.Log("etkile�im s�r�yor");
    }
    
    private void OnCollisionExit(Collision collision)    // etkile�im bitti�in an �al��ma funct
    {
        Debug.Log("etkile�im bitti");
    }
    


    //collider �arp��ma yakalama(en az bir nesnede is trigger a��k olmal�)

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "sari")              //carp��t��� nesneyi ismi ile yakalama
        {
            Debug.Log("etkile�im var");
        }


    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("deneme"))                   //carp��t��� nesneyi tag� ile yakalama
        {
            Debug.Log("etkile�im s�r�yor");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "sari")             //carp��t��� nesneyi ismi ile yakalama
        {          
            Debug.Log("etkile�im bitti");
        }
    }
}
