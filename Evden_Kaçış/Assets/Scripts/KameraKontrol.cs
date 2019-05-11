using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour
{
    Vector2 mouselook;
    Vector2 smoothV;
    public float sensivity = 5.0f;
    public float smoothing = 2.0f;
    GameObject karakter;

    // Start is called before the first frame update
    void Start()
    {
        karakter = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector2.Scale(md, new Vector2(sensivity * smoothing, sensivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        mouselook += smoothV;

        transform.localRotation = Quaternion.AngleAxis(-mouselook.y, Vector3.right);
        karakter.transform.localRotation = Quaternion.AngleAxis(mouselook.x, karakter.transform.up);
    }
}
