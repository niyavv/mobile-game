using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleDestroy : MonoBehaviour
{
    
     public void OnTriggerEnter2D(Collider2D collision){
         
         Destroy(gameObject);
     }
 }
