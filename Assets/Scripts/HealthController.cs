using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField] float MaxHealth = 100;

    private float _currentHealth;

    public float CurrentHealth { get => _currentHealth; }

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

