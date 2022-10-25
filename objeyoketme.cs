using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class objeyoketme : MonoBehaviour
{
    
    void Start()
    {
        
        Destroy(gameObject,2); // objeyi yok eder. virgülden sonrasý kaç saniye sonra yok edeceðini belirtir.
        Destroy(this);           // objeden script dosyasýný siler.
        Destroy(GetComponent("SphereCollider")); //collider siler
    }

    
}
