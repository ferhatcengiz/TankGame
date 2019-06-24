using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class tankAI : MonoBehaviour {

    public Transform[] waypointsTranform;
    Vector3 pointA, pointB;
    Transform playerTank;
    NavMeshAgent agent;
    int currentIndex = 0;
    float maxCheckDistance = 10;
	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        pointA = waypointsTranform[0].position;
        pointB = waypointsTranform[1].position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        Vector3 dir = (playerTank.position - transform.position).normalized;
        Ray ray = new Ray(transform.position, dir);
        //RaycastHit hitInfo;
        Debug.DrawRay(ray.origin, ray.direction * maxCheckDistance, Color.red);
        if (Physics.Raycast(ray,maxCheckDistance))
        {

        }

	}

    public void FindNewWayPoint()
    {
        switch (currentIndex)
        {
            case 0:
                currentIndex = 1; break;
            case 1:
                currentIndex = 0; break;
        }

    }

}
