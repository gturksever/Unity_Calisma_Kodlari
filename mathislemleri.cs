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
        string metin = "güzel bir metin yazalým buraya";
        string[] parcala = metin.Split(' '); //bosluk karakterlerinden sonrasýný parçalar ve diziye atar.
        metin.ToUpper(); //harfleri büyütür
        metin.ToLower(); //harfleri küçültür
        metin.Replace("s", "y"); // s karakterlerini y karakterlerine dönüþtürür        
        metin.Trim(); //baþtaki ve sondaki boþluklarý siler
        metin.Substring(2,10);// metin içerisinde indis numarasý ile cýmbýzlama

        print(Ad.GetType()); //deðiþken tipi öðrenme

        
        print(Mathf.Max(saglikdizi)); // dizideki en yüksek deðeri çeker
        print(Mathf.Min(saglikdizi)); // dizideki en düþük  deðeri çeker
        print(Mathf.Clamp(saglik, 1, 100)); // deðiþkeni belirtilen deðerler arasýnda sýnýrlar.
        print(Mathf.Round(5.2f)); // ondalýklý sayýyý yuvarlar .5 ise yuvarlayacaðý sayýyý çift olana yuvalar 1.5=> 2  2.5=>2 gibi
        print(Mathf.Abs(-2.5f)); //.abs mutlak deðer alýr


    }
   
}
