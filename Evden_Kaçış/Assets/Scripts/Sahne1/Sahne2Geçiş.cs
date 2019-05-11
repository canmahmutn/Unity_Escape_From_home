using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sahne2Geçiş : MonoBehaviour
{
    public void OnTriggerEnter(Collider col1)
    {
        if (col1.gameObject.name == "Karakter")//Eğer trigger'ımızı Karakter adlı obje tetiklediyse kitabı okumak için yönlendirme text'ini bir defalık gösterdim
        {

            SceneManager.LoadScene(2);
        }
    }
}
