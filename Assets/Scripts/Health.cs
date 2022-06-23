using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour

    
{
    public float Healing = 25;

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<HealthController>().CurrentHealth += Healing;
        Destroy(gameObject);
    }



}
