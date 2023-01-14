using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public bool isDead;
    public float velocity = 1f;
    public Rigidbody2D rb2D;
    public GameManager managerGame;
    public float speed; 
    public float time;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))//týklamayý al
            {
                rb2D.velocity = Vector2.up * velocity;//vektör 2 yönünde yukarý doðru zýplat
            }

            float horizontal = Input.GetAxis("Horizontal");
            HorizantalMove(horizontal);

    }
    private void HorizantalMove(float horizontal){

        rb2D.velocity = new Vector2(speed*horizontal,rb2D.velocity.y);

    }
    private void OnTriggerEnter2D(Collider2D collision)//içinden geçmesi gerek
    {
        if(collision.gameObject.name == "Apple")//eðer apple objesinin içinden geçerse
        {
            managerGame.UpdateScore();//fonksiyonu çalýþtýr
        }
        if(collision.gameObject.name == "Banana")//eðer banana objesinin içinden geçerse
        {
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)//çarpýþmasý yeterli
    {
        if(collision.gameObject.tag == "DeathArea")//eðer deatharea ile çarpýþýrsa 
        {
            isDead = true;//ölü olsun
            Time.timeScale = 0;//zamaný durdur
        }
    }
    
}

