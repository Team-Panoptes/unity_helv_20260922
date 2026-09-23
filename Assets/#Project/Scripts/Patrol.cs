using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;

[RequireComponent(typeof(NavMeshAgent))]
public class Patrol : MonoBehaviour
{
    private NavMeshAgent agent;
    [SerializeField]private List<Transform> targets;
    private int index = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(targets[index++].position);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.pathStatus == NavMeshPathStatus.PathComplete){
            if (agent.remainingDistance <= agent.stoppingDistance){
                Debug.Log($"index: {index}");
                if(index < targets.Count){
                    agent.SetDestination(targets[index++].position);
                }
            }
        }
    }
}
