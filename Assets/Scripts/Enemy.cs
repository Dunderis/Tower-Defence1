using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private int targetindex;
    private NavMeshAgent agent;
    private bool endPointReached = false;
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!endPointReached)
        {
            agent.SetDestination(Path.instance.waypoints[targetindex].position);
            var dsitance = Vector3.Distance(transform.position, Path.instance.waypoints[targetindex].position);
            if (dsitance < 0.6f)
            {
                targetindex++;
                if (targetindex >= Path.instance.waypoints.Count)
                {
                    endPointReached = true;
                }
            }
        }
        else
        {
          //attack  
        }
       
    }
}
