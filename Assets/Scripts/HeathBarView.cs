using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeathBarView : MonoBehaviour
{
    [SerializeField] Image Image;
    private HealthController _healthController;


    void Start()
    {
        _healthController = FindObjectOfType<HealthController>();
        _healthController.HealthChange += OnHealthChanged;
    }

    void OnHealthChanged(float curentHealth)
    { 
      Image.fillAmount = curentHealth / _healthController.MaxHealth;
    }
    
}
