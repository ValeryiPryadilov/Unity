using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    float Damage = 20;

    IEnumerator Delete()
    {
        yield return new WaitForSeconds(5);

        if (gameObject != null)
        { 
            Destroy(gameObject);        
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<HealthController>().CurrentHealth -= Damage;

            Destroy(gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Delete());
    }

    
}
