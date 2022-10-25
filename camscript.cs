using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Oyun içerisinde Birden fazla kamera arasýnda deðiþim yapmamýzý saðlayan script
public class camscript : MonoBehaviour
{
    public Camera Main_Camera;
    public Camera Ikinci_Camera;
    public Camera Ucuncu_Camera;

    private void Camera_Kontrol()
    {
       

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Main_Camera.enabled == true && Ikinci_Camera.enabled == false && Ucuncu_Camera.enabled == false)
            {
                Ikinci_Camera.enabled = true;
                Main_Camera.enabled = false;

            }

            else if (Main_Camera.enabled == false && Ikinci_Camera.enabled == true && Ucuncu_Camera.enabled == false)
            {

                Ucuncu_Camera.enabled = true;
                Ikinci_Camera.enabled = false;
            }

            else if (Main_Camera.enabled == false && Ikinci_Camera.enabled == false && Ucuncu_Camera.enabled == true)
            {

                Main_Camera.enabled = true;
                Ucuncu_Camera.enabled = false;
            }
        }
    }

    void Start()
    {
        Ikinci_Camera.enabled = false;  
        Ucuncu_Camera.enabled = false;  
    }

    void Update()
    {
        Camera_Kontrol();
    }
}
