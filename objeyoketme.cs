using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class objeyoketme : MonoBehaviour
{
    
    void Start()
    {
        
        Destroy(gameObject,2); // objeyi yok eder. virg�lden sonras� ka� saniye sonra yok edece�ini belirtir.
        Destroy(this);           // objeden script dosyas�n� siler.
        Destroy(GetComponent("SphereCollider")); //collider siler
    }

    
}
