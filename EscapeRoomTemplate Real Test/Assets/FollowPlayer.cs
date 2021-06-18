using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Transform player;
    [SerializeField] private float distanceFromPlayer;
    [SerializeField] private float distanceThreshold;
    [SerializeField] private bool isFollowing = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GetDistanceToTarget(player) < distanceThreshold && isFollowing)
        {
            agent.destination = player.transform.position;
        }
        
        //Debug.Log("Distance: " + GetDistance());
    }

    private float GetDistanceToTarget(Transform target)
    {
        distanceFromPlayer = Vector3.Distance(transform.position, target.position);
        return distanceFromPlayer;
    }
}
