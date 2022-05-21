using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNT : MonoBehaviour
{
    [SerializeField] float Forse = 5000;
    [SerializeField] float Radius = 100;
    [SerializeField] float Damage = 10;

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Rigidbody>().AddExplosionForce(Forse, transform.position, Radius);
        other.GetComponent<HealthController>().GetDamage(Damage);
        Destroy(gameObject);

    }


    
   
}
