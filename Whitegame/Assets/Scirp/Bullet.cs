using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 7f;

    Rigidbody2D rb;

    public int AttackBack = 0;
    PlayerMovement target;
    Enemy target2;
    Vector2 moveDirection;

    void Start(){
        if(AttackBack == 0){
        rb= GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<PlayerMovement>();
        moveDirection = (target.transform.position - transform.position).normalized*moveSpeed;
        rb.velocity = new Vector2(moveDirection.x,moveDirection.y);
        Destroy(gameObject,3f);
        }
    }
    public void Update(){
        if(AttackBack == 1){
            rb= GetComponent<Rigidbody2D>();
            target2 = GameObject.FindObjectOfType<Enemy>();
             moveDirection = (target2.transform.position - transform.position).normalized*moveSpeed;
        rb.velocity = new Vector2(moveDirection.x,moveDirection.y);
        Destroy(gameObject,3f);
        }
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            PlayerMovement.instance.PlayerTakeDamage(10);
            Destroy(gameObject);
        }
        if(other.tag == "AttackBack"){
            AttackBack = 1;
        }
        if(other.tag == "Enemy"){
            Enemy.instance.TakeDamage(10);
            Destroy(gameObject);
        }
    }
}
