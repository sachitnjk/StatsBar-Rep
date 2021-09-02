using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthBarController : MonoBehaviour
{
    
    public Slider healthBar;
    public int currentHp = 100;
    

     public void changeHp(int dHp)
    {
        currentHp += dHp;
    }


    void Start()
    {
        healthBar = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {

        healthBar.value = currentHp;
    }

}
