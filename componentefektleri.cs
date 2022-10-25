using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class componentefektleri : MonoBehaviour
{
    // 2 obje aras�nda �izgi �izer
    LineRenderer line;
    public Transform hedef;
    
    private void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        line.SetPosition(0, transform.position);
        line.SetPosition(1, hedef.position);
        
        
    }

    /*Trial Renderer: arkadan ��kan duman // u�ak����� efektidir nesnenin arkas�ndan nesneyi takip eden efekttir
    * time: ne kadar s�re �al��aca��n� belirler
    * autodestruct: efekt �al���p durunca nesneyi otomatik siler
    * verticles: arkadaki �izgilerin k��elili�ini ve yumu�akl�l���n� ayarlar
    * texture mode: elleme
    * materials: buraya atad���n materyali arkada ��kart�r
    * probes:  efektin sahnedeki probles lar� kullan�p kullanmayaca��n� se�eriz
    */

    /*Line Renderer: silahlardaki lazer. / bir noktadan �b�r noktaya �izgi �izer
     * use world space: a��l�rsa d�nyaya g�re; kapan�rsa ait oldu�u objeye g�re hareket eder.
     */

    /*Lens flare: yans�ma efekti kamera sniper scopu, g�ne� vs vs gibi.
     */

    /*Halo: etrafta i�ine yakla�t�kca yok olan �ember evekti gir bak.
     * 
     */

    /* projector: verdi�in materyali biryere yans�t�r.
     */







    
}
