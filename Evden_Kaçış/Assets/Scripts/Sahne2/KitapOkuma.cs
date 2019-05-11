using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitapOkuma : MonoBehaviour
{
    bool mesajgöster = true;
    //public GameObject uiobject;//ekrana basılacak text'leri gameobject olarak aldım
    public GameObject uiobject2;
    public GameObject kapii2;
    private void Start()
    {
        //uiobject.SetActive(false);//baslangicta textleri kapattım
        uiobject2.SetActive(false);

    }
    public void OnTriggerStay(Collider col1)
    {
        if (col1.gameObject.name == "Karakter")//Eğer trigger'ımızı KArakter adlı obje tetiklediyse kitabı okumak için yönlendirme text'ini bir defalık gösterdim
        {
            //uiobject.SetActive(mesajgöster);
            if (Input.GetKeyDown(KeyCode.E))//E'ye basılınca kapının belirmesini, defterin içindeki notun ekrana basılmasını sağladım
            {
                Renderer rend = kapii2.GetComponent<Renderer>();
                rend.enabled = true;
                mesajgöster = false;
                //uiobject.SetActive(mesajgöster);
                uiobject2.SetActive(true);
            }

        }
    }
    public void OnTriggerExit(Collider col2)
    {
        if (col2.gameObject.name == "Karakter")
        {
            //uiobject.SetActive(false);
            uiobject2.SetActive(false);
            if (!mesajgöster)
            {
                Renderer rend = kapii2.GetComponent<Renderer>();
                rend.enabled = true;
            }
        }
    }




}
