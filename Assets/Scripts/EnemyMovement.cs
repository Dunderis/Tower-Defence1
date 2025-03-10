using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public Transform[] waypoints;

    private int x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(waypoints[x].position);
        transform.position += transform.forward * speed * Time.deltaTime;
        var distance = Vector3.Distance(transform.position, waypoints[x].position);
        if (distance < 0.5f &&  x<waypoints.Length - 1)
        {
            x++;
        }
        {
            
        }
    }
}
