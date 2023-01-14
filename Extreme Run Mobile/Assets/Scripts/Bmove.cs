using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bmove : MonoBehaviour
{
    public float speed;

    void Start()
    {
        Destroy(gameObject , 16);//16 saniye sonra objeyi yok et
    }
    
    void FixedUpdate()
    {
        
        transform.position += Vector3.left * speed * Time.deltaTime; //karaktere doðru gelen objelerin hareket kodu

    }
}
