using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mathislemleri : MonoBehaviour

{

    //private string Ad = "gorkem";
    //private string Ad2 = "mehmet";
    //private int sayi = 50;
    //float saglik = -5;
    //int[] saglikdizi={1,2,3,4,5};
    void Start()
    {
        string metin = "g�zel bir metin yazal�m buraya";
        string[] parcala = metin.Split(' '); //bosluk karakterlerinden sonras�n� par�alar ve diziye atar.
        metin.ToUpper(); //harfleri b�y�t�r
        metin.ToLower(); //harfleri k���lt�r
        metin.Replace("s", "y"); // s karakterlerini y karakterlerine d�n��t�r�r        
        metin.Trim(); //ba�taki ve sondaki bo�luklar� siler
        metin.Substring(2,10);// metin i�erisinde indis numaras� ile c�mb�zlama

        print(Ad.GetType()); //de�i�ken tipi ��renme

        
        print(Mathf.Max(saglikdizi)); // dizideki en y�ksek de�eri �eker
        print(Mathf.Min(saglikdizi)); // dizideki en d���k  de�eri �eker
        print(Mathf.Clamp(saglik, 1, 100)); // de�i�keni belirtilen de�erler aras�nda s�n�rlar.
        print(Mathf.Round(5.2f)); // ondal�kl� say�y� yuvarlar .5 ise yuvarlayaca�� say�y� �ift olana yuvalar 1.5=> 2  2.5=>2 gibi
        print(Mathf.Abs(-2.5f)); //.abs mutlak de�er al�r


    }
   
}
