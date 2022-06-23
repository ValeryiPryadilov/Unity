using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public float MaxHealth = 100;

    private float _currentHealth;

    
    public float CurrentHealth 
    
    { 
        get => _currentHealth;
        set 
        {
          _currentHealth = value;
            HealthChange.Invoke(_currentHealth);
        }
    
    }
    public Action<float> HealthChange;

    void Start()
    {
        
        _currentHealth = MaxHealth;
        Debug.Log(_currentHealth);
        
    }

    public void GetDamage(float damage)
    {
        _currentHealth -= damage;
        Debug.Log(_currentHealth);
        if (CurrentHealth < 0)
        {
            
        }
  
    
    }
    public void Healing(float Heal)
    {
        _currentHealth += Heal;
        Debug.Log(_currentHealth);
    }
}

