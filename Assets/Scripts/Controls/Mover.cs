using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent = null;  // Nav mesh agent of this character

    [SerializeField] private Transform target = null;


    // Update is called once per frame
    void Update()
    {
        agent.destination = target.position;
    }
}
