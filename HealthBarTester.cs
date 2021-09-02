using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarTester : MonoBehaviour
{
    
    public HealthBarController healthBar;

    void Start()
    {
        healthBar = GameObject.Find("Health Bar").GetComponent<HealthBarController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.UpArrow))
        {
            healthBar.changeHp(1);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            healthBar.changeHp(-1);
        }

    }
}
