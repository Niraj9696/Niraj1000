using StarterAssets;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    FirstPersonController player;
    UnityEngine.AI.NavMeshAgent agent;
    void Awake()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    // Start is called before the first frame update
    void Start()
    {
        player = FindFirstObjectByType<FirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
    }
}
