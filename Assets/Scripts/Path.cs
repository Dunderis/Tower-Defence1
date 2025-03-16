using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Path : MonoBehaviour
{
    public static Path instance;
    public List<Transform> waypoints;
    // Start is called before the first frame update
    private void Awake()
    {
        if(instance == null) instance = this;
    }
    private void OnDrawGizmos()
    {
        if(waypoints.Count < 2) return;
        Gizmos.color = Color.yellow;
        for (int i = 0; i < waypoints.Count-1; i++)
        {
            if (waypoints[i] != null && waypoints[i+1] != null)
            {
                Gizmos.DrawLine(waypoints[i].position, waypoints[i + 1].position);
            }
            
        }
    }
}
