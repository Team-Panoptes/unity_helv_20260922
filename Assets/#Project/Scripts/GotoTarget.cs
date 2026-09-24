using UnityEngine;
using UnityEngine.AI;

public class GotoTarget : MonoBehaviour
{
    [SerializeField] private Transform target;
    private NavMeshAgent agent;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(target.position);
        agent.avoidancePriority = Random.Range(1, 100);
        agent.radius = Random.Range(0.7f, 1f);
    }

    void Update()
    {

    }
}
