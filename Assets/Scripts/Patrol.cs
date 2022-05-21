using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    [SerializeField] Transform[] Points;
    NavMeshAgent agent;
    bool isPotruling;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = Points[0].position;
        StartPatrul();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance < 0.5 && isPotruling)

        {
            agent.destination = Points[Random.Range(0 , Points.Length)].position;


        }
    }
    public void StartPatrul() 
    {
      isPotruling = true;
        agent.ResetPath();

    }
    public void StopPatrul()
    {
        isPotruling = false;
        agent.ResetPath();
    }

}   
