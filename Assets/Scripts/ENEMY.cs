using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ENEMY : MonoBehaviour
{
    NavMeshAgent agent;
    bool detention;
    Transform player;
    [SerializeField] float MaxDamage = 10;
    [SerializeField] float AtackDistance = 0.5f;
    [SerializeField] float CoolDownTime = 1;
    float currentTime = 0;
    Patrol patrol;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        patrol = GetComponent<Patrol>();
    }

    // Update is called once per frame
    void Update()
    {
        if (detention) 
        
        {
            agent.destination = player.position;

            currentTime += Time.deltaTime;

            if (agent.remainingDistance < AtackDistance && currentTime >= CoolDownTime)
            {
                Atack(player.gameObject);
                
                currentTime = 0;


            }

        }
        

    }






    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            // go to player 
            detention = true;
            player = other.transform;
            patrol.StopPatrul();
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            detention = false;
            player = null;
            patrol.StartPatrul();
        }
    }
    private void Atack(GameObject Player) 
    
    {
        Player.GetComponent<HealthController>().CurrentHealth -= MaxDamage;

    }
}


