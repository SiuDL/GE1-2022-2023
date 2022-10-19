using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AITank : MonoBehaviour {

    public float radius = 10;
    public int numWaypoints = 5;
    public int current = 0;
    List<Vector3> waypoints = new List<Vector3>();
    public float speed = 3;
    public Transform player;    

    public float CalculateThetaPoint(int n)
    {
        return (Mathf.PI * 2.0f) / n;
    }

    public void OnDrawGizmos()
    {
        if (!Application.isPlaying)
        {
            // Task 1
            // Put code here to draw the gizmos
            // Use sin and cos to calculate the positions of the waypoints 
            // You can draw gizmos using
            float thetaPoint = CalculateThetaPoint(numWaypoints);
            for(int i = 0; i < numWaypoints; i++)
            {
                float theta = thetaPoint * i;
                Vector3 p = new Vector3(Mathf.Sin(theta) * radius, 0, Mathf.Cos(theta) * radius);
                p = transform.TransformPoint(p);
                Gizmos.color = Color.red;
                Gizmos.DrawWireSphere(p, 1);
            }
        }
    }

    // Use this for initialization
    void Awake () {
        // Task 2
        // Put code here to calculate the waypoints in a loop and 
        // Add them to the waypoints List
        float thetaPoint = CalculateThetaPoint(numWaypoints);
        for(int i = 0; i < numWaypoints; i++)
        {
            float theta = thetaPoint * i;
            Vector3 p = new Vector3(Mathf.Sin(theta) * radius, 0, Mathf.Cos(theta) * radius);
            p = transform.TransformPoint(p);
            waypoints.Add(p);
        }
    }

    // Update is called once per frame
    void Update () {
        // Task 3
        // Put code here to move the tank towards the next waypoint
        // When the tank reaches a waypoint you should advance to the next one
        Vector3 point = waypoints[current] - transform.position;
        if(point.magnitude < 1)
        {
            current += 1 % waypoints.Count;
        }
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(point), Time.deltaTime *  10);
        transform.Translate(point * speed * Time.deltaTime, Space.World);

        // Task 4
        // Put code here to check if the player is in front of or behine the tank
        // Task 5
        // Put code here to calculate if the player is inside the field of view and in range
        // You can print stuff to the screen using:
        GameManager.Log("Hello from th AI tank");
    }
}
