using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class patrullando_cazador : MonoBehaviour
{
    public Transform[] patrolPoints; 
    private int currentPointIndex = 0;
    private NavMeshAgent agent;

    public float arrivalThreshold = 0.5f; 

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (patrolPoints.Length > 0)
        {
            agent.SetDestination(patrolPoints[currentPointIndex].position);
        }
    }

    void Update()
    {
        if (agent.remainingDistance <= arrivalThreshold && !agent.pathPending)
        {
            GoToNextPoint();
        }
    }

    void GoToNextPoint()
    {
        currentPointIndex = (currentPointIndex + 1) % patrolPoints.Length;
        agent.SetDestination(patrolPoints[currentPointIndex].position);
    }
}
