using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Move MoveScript;
    public GameObject SpikeHead;
    public float height;
    public float time;

    public void Start(){

    StartCoroutine(SpawnObject(time));//time süresinde bir rutinde obje spawn et

    }

    public IEnumerator SpawnObject(float time){

    while (!MoveScript.isDead)//eðer karakter ölü deðilse
    {
        Instantiate (SpikeHead , new Vector3 (1 , Random.Range(-height , height), 0), Quaternion.identity);//bu aralýkta spike head objesi

        yield return new WaitForSeconds(time);

    }
    }
}
