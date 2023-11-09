using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
     // khai bao nhat vat
    private Transform nhanvat;
    // Start is called before the first frame update
    void Start()
    {
        //anh xa nhan vat vao code (findByViewID)
        nhanvat = GameObject.Find("player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cam = transform.position; //camera nhan gia tri cu cua nhan vat
        cam.x = nhanvat.position.x; //chuyen toa do x cua nhan vat cho camera
        transform.position = cam; //nhan vat nhan gia tri moi
    }
}
