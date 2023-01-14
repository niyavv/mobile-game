using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaSpawner : MonoBehaviour
{
    public Move MoveScript;
    public GameObject Banana;
    public float height;
    public float time;
    private void Update(){
    
    StartCoroutine(SpawnObject(time));//time s�resinde bir rutinde obje spawn et

    }

    public IEnumerator SpawnObject(float time){

    while (!MoveScript.isDead)//e�er karakter �l� de�ilse
    {
       var instantiatedObject = Instantiate (Banana , new Vector3 (1 , Random.Range(-height , height), 0), Quaternion.identity);//hangi nesne, hangi aral�kta, ne kadar

       instantiatedObject.name = "Banana";

        yield return new WaitForSeconds(time);//yeni obje i�in time kadar bekle
         
    }

    }
}