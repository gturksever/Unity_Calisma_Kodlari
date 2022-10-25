using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listcalisma : MonoBehaviour
{
   
    void Start()
    {
        List<int> sila = new List<int>();       // Liste tan�mlamas�
        sila.Add(24);                           // Listenin sonuna eleman ekler
        sila.Add(23);                           // Listenin sonuna eleman ekler

        List<string> gorkem = new List<string>();
        gorkem.Add("Mustafa");
        gorkem.Add("G�rkem");
        gorkem.Add("T�rksever");

        Debug.Log(sila.Count);                  // Listenin eleman say�s�
        Debug.Log(gorkem.Count);

        int[] dizi = new int[] {1,2,3,4};       // Dizi Tan�mlamas�
         
        Debug.Log(dizi.Length);                 // Dizinin eleman say�s�

            if (gorkem.Contains("Mustafaf"))    // Aranan eleman listin i�inde var m�?
            {
                print("evet var");
            }

            else
            {
                print("hay�r yok");
            }

        sila.Clear();                           // B�t�n listeyi temizler
        
        

    }

  
}
