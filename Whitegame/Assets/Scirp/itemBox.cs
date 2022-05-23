using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBox : MonoBehaviour
{
    public GameObject ItemBack;
    public GameObject[]Function_button;
    public void BACK(){
    ItemBack.SetActive(false);
    Function_button[0].SetActive(true);
    Function_button[1].SetActive(true);
    Function_button[2].SetActive(true);
    Function_button[3].SetActive(true);
    }
    
    public void Water(){
        PlayerMovement.instance.PlayerTakeHealth(5);
    }
}
