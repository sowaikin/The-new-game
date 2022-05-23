using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAttack : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;
    
    float fireRate;
    float nextFire;

    void Start(){
        fireRate = 1f;
        nextFire = Time.time;
    }

    void Update(){
        CheckIfTimeToFire();
    }
    void CheckIfTimeToFire(){
        if(Time.time > nextFire){
            Instantiate(bullet,transform.position,Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}
