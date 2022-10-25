using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listcalisma : MonoBehaviour
{
   
    void Start()
    {
        List<int> sila = new List<int>();       // Liste tanýmlamasý
        sila.Add(24);                           // Listenin sonuna eleman ekler
        sila.Add(23);                           // Listenin sonuna eleman ekler

        List<string> gorkem = new List<string>();
        gorkem.Add("Mustafa");
        gorkem.Add("Görkem");
        gorkem.Add("Türksever");

        Debug.Log(sila.Count);                  // Listenin eleman sayýsý
        Debug.Log(gorkem.Count);

        int[] dizi = new int[] {1,2,3,4};       // Dizi Tanýmlamasý
         
        Debug.Log(dizi.Length);                 // Dizinin eleman sayýsý

            if (gorkem.Contains("Mustafaf"))    // Aranan eleman listin içinde var mý?
            {
                print("evet var");
            }

            else
            {
                print("hayýr yok");
            }

        sila.Clear();                           // Bütün listeyi temizler
        
        

    }

  
}
