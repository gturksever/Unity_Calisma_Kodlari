using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fizikyakalama : MonoBehaviour
{
    //rigidbody çarpýþma yakalama

    //rigidbody çarpýþma yakalamanýn çalýþmasý için çarptýðý nesnenin rigidbody componentine sahip olmasýna gerek yoktur!!!
    
    private void OnCollisionEnter(Collision collision) //rigidbody ilk etkileþim aný funct
    {
        if (collision.gameObject.name=="sari")           //carpýþtýðý nesneyi ismi ile yakalama
        {
            Debug.Log("etkileþim var");
        }
    }
    
    private void OnCollisionStay(Collision collision)    //rigidbody etkileþim devam ettikce sürdürme funct
    {
        Debug.Log("etkileþim sürüyor");
    }
    
    private void OnCollisionExit(Collision collision)    // etkileþim bittiðin an çalýþma funct
    {
        Debug.Log("etkileþim bitti");
    }
    


    //collider çarpýþma yakalama(en az bir nesnede is trigger açýk olmalý)

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "sari")              //carpýþtýðý nesneyi ismi ile yakalama
        {
            Debug.Log("etkileþim var");
        }


    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("deneme"))                   //carpýþtýðý nesneyi tagý ile yakalama
        {
            Debug.Log("etkileþim sürüyor");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "sari")             //carpýþtýðý nesneyi ismi ile yakalama
        {          
            Debug.Log("etkileþim bitti");
        }
    }
}
