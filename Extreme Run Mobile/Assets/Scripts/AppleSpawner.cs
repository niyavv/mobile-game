using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawner : MonoBehaviour
{
    public Move MoveScript;
    public GameObject Apple;
    public float height;
    public float time;
    private void Start(){

    StartCoroutine(SpawnObject(time));//time süresinde bir rutinde obje spawn et

    }

    public IEnumerator SpawnObject(float time){

    while (!MoveScript.isDead)//eðer karakter ölü deðilse
    {
        var instantiatedObject = Instantiate (Apple , new Vector3 (1 , Random.Range(-height , height), 0), Quaternion.identity);//hangi nesne, hangi aralýkta, ne kadar
        
        instantiatedObject.name = "Apple";//adý apple olacak objeler

        yield return new WaitForSeconds(time);//yeni obje için time kadar bekle
         
    }
    }
}