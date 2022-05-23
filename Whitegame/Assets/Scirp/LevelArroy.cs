using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelArroy : MonoBehaviour
{
    public GameObject[] LevelSeyty;
    
    public float[] addtime;
    public float time = 0;
    public int i = 0;
    public int max;
    public bool Open = true;

    public GameObject Diago;

    public GameObject ItemBox;
    public GameObject[] Function_button;

    // Update is called once per frame
    void Update()
    { 
       if(time >=0){
        time = time - 1 * Time.deltaTime; 
        }
        if(time <= 0 && Open == false){
            LevelSeyty[i].SetActive(false);
            Time.timeScale = 1;
            Diago.SetActive(true);
            Open = true;
        }
    }
    public void Attack(){
        if(max > i && time <= 0)
        {
           LevelSeyty[i].SetActive(true);
           Function_button[0].SetActive(false);
           Function_button[1].SetActive(false);
           Function_button[2].SetActive(false);
           Function_button[3].SetActive(false);
           time = time + addtime[i];
           Open = false;
        }

    }
    public void Ans(){
        
        i++;
        time = 0;
        Function_button[0].SetActive(true);
        Function_button[1].SetActive(true);
        Function_button[2].SetActive(true);
        Function_button[3].SetActive(true);
        Diago.SetActive(false);
        if(max <= i){
            i =0;
        }
    }

    public void OpenItem(){
        ItemBox.SetActive(true);
    }
}
