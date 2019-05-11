using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KapıTetikleyici : MonoBehaviour
{
    public GameObject kapii;
    public void OnTriggerStay(Collider col1)
    {
        Renderer rend = kapii.GetComponent<Renderer>();
        if (col1.gameObject.tag == "Karakter")
            {
            //kapii.SetActive(true);
            if (!rend.enabled)
            {
                rend.enabled = true;
            }
            }
    }
    public void OnTriggerExit(Collider col1)
    {
        Renderer rend = kapii.GetComponent<Renderer>();
        if (col1.gameObject.tag == "Karakter")
        {
            //kapii.SetActive(true);
            if (rend.enabled)
            {
                rend.enabled = false;
            }
        }
    }

    //public void OnCollisionExit(Collision col2)
    //{
    //    Renderer rend = kapii.GetComponent<Renderer>();
    //    if (col2.gameObject.tag == "Karakter")
    //    {
    //        //kapii.SetActive(false);
    //        if (rend.enabled)
    //        {
    //            rend.enabled = false;
    //        }

    //    }
    //}

}
