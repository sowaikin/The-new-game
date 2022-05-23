using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float  speed= 20f;
    private Rigidbody2D rb;
    public Vector2 movement;

    public GameObject player;

    public GameObject[] defensive;
    public int defensivenumber1 = 0;
    public int defensivenumber2 = 0;
    public int defensivenumber3 = 0;

    public int maxHealth = 100;
    public int currentHealth;

        public static PlayerMovement instance;

    private void Awake(){
        if(instance == null){
            instance = this;
        }
    }
    public void Start(){
         currentHealth = maxHealth;
        rb=GetComponent<Rigidbody2D>();  
    }
    public void Update()
    {   
    movement.y=Input.GetAxis("Vertical");
    movement.x=Input.GetAxis("Horizontal");

    if(Input.GetKeyDown(KeyCode.I)){
        if(defensivenumber1 == 0){
        defensive[0].SetActive(true);
        StartCoroutine(ExampleCoroutine());
        defensivenumber1 = 1;
        }
    }
        if(Input.GetKeyDown(KeyCode.J)){
        if(defensivenumber2 == 0){
        defensive[1].SetActive(true);
        StartCoroutine(ExampleCoroutine1());
        defensivenumber2 = 1;
        }
    }
        if(Input.GetKeyDown(KeyCode.L)){
        if(defensivenumber3 == 0){
        defensive[2].SetActive(true);
        StartCoroutine(ExampleCoroutine2());
        defensivenumber3 = 1;
        }
    }
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
            
    IEnumerator ExampleCoroutine(){
            yield return new WaitForSeconds(1);
             defensive[0].SetActive(false);
             defensivenumber1 = 0;
      }
    IEnumerator ExampleCoroutine1(){
            yield return new WaitForSeconds(1);
             defensive[1].SetActive(false);
             defensivenumber2 = 0;
      }
    IEnumerator ExampleCoroutine2(){
            yield return new WaitForSeconds(1);
             defensive[2].SetActive(false);
             defensivenumber3 = 0;
      }
     public void PlayerTakeDamage(int damage){
        currentHealth -= damage;

        if(currentHealth <= 0){
            Die();
        }
    }
    public void PlayerTakeHealth(int Health){
        currentHealth += Health;

        if(currentHealth > 100){
            currentHealth = 100;
        }
    }
      void Die(){
        Debug.Log("Enemy died");
    }

}
