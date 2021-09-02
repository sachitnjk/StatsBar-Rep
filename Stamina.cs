using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stamina : MonoBehaviour
{

    [SerializeField] float maxStamina = 100;
    [SerializeField] float decayRate = 10;
    [SerializeField] float regenRate = 5;
    public Slider staminaBar;
    public bool sprinting;
    public float currentStamina;
    public float CurrentStamina {
        get {
            return currentStamina;
        }
        set {
            currentStamina = value;
            staminaBar.value = currentStamina;
        }
    }
    

    void Start()
    {
        staminaBar = GetComponent<Slider>();
        staminaBar.maxValue = maxStamina;
        staminaBar.value = maxStamina;
    }


    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            sprinting = true;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            sprinting = false;
        }
        ManageSprintSlider();

    }

    public void ManageSprintSlider() {
        if(sprinting)
        {
            if(CurrentStamina > 0)
            {
                CurrentStamina -= decayRate * Time.deltaTime;
            }
            else
            {
                sprinting = false;
            }
        }
        else
        {
            if(CurrentStamina < maxStamina)
            {
                CurrentStamina += regenRate * Time.deltaTime;
            }
        }
    }


}
