using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class componentefektleri : MonoBehaviour
{
    // 2 obje arasýnda çizgi çizer
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

    /*Trial Renderer: arkadan çýkan duman // uçakýþýðý efektidir nesnenin arkasýndan nesneyi takip eden efekttir
    * time: ne kadar süre çalýþacaðýný belirler
    * autodestruct: efekt çalýþýp durunca nesneyi otomatik siler
    * verticles: arkadaki çizgilerin köþeliliðini ve yumuþaklýlýðýný ayarlar
    * texture mode: elleme
    * materials: buraya atadýðýn materyali arkada çýkartýr
    * probes:  efektin sahnedeki probles larý kullanýp kullanmayacaðýný seçeriz
    */

    /*Line Renderer: silahlardaki lazer. / bir noktadan öbür noktaya çizgi çizer
     * use world space: açýlýrsa dünyaya göre; kapanýrsa ait olduðu objeye göre hareket eder.
     */

    /*Lens flare: yansýma efekti kamera sniper scopu, güneþ vs vs gibi.
     */

    /*Halo: etrafta içine yaklaþtýkca yok olan çember evekti gir bak.
     * 
     */

    /* projector: verdiðin materyali biryere yansýtýr.
     */







    
}
