using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour
{
    public Transform Goal;
    public NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = Goal.position;
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = Goal.position;

        if(agent.destination != null)
            agent.destination = Goal.position;
    }
}
