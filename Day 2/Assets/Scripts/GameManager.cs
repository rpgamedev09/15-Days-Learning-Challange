using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int health, shield;

    private int maxHealth = 10,maxShield = 10;

    [SerializeField] private Slider healthSlider;
    [SerializeField] private Slider shieldSlider;
    private void Awake()
    {
        instance = this;
        
        health = maxHealth;
        shield = maxShield;

        healthSlider.maxValue = maxHealth;
        shieldSlider.maxValue = maxShield;  
    }
    private void Update()
    {
        healthSlider.value = health;
        shieldSlider.value = shield;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            health -= maxHealth;
            shield -= maxShield;    
        }
    }





}
