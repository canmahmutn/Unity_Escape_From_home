using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SonKontrol : MonoBehaviour
{
    public GameObject kapii3;
    public void OnTriggerEnter(Collider col1)
    {
        Renderer rend = kapii3.GetComponent<Renderer>();
        if (col1.gameObject.tag == "Karakter")
        {
            //kapii.SetActive(true);
            if (rend.enabled)
            {
                SceneManager.LoadScene(3);
            }
        }
    }
    
}
