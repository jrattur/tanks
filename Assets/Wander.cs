using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour
{
    public GameObject waypointsGameObjects;
    private Transform[] waypoints;
    public int currentWaypoint = 0;
    public float waypointDistanceInc = 20f;

    public float force = 100;

    public float rotationSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        waypoints = waypointsGameObjects.GetComponentsInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        float distanceToWaypoint = (waypoints[currentWaypoint].position - transform.position).magnitude;

        if (distanceToWaypoint < waypointDistanceInc) {
            currentWaypoint++;
            if (currentWaypoint >= waypoints.Length) { currentWaypoint = 0; }
        }

        Vector3 direction = waypoints[currentWaypoint].position - transform.position;
        /*Quaternion toRotation = Quaternion.FromToRotation(transform.forward, direction);
        toRotation = Quaternion.Euler(new Vector3(0f, toRotation.eulerAngles.y, 0f));
        transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, rotationSpeed * Time.time);
        */
        float angle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        Quaternion zzz = Quaternion.Euler(0f, angle, 0f);

        transform.rotation = Quaternion.Slerp(transform.rotation, zzz, Time.deltaTime * rotationSpeed);

        //transform.LookAt(Vector3.Lerp(transform.position, waypoints[currentWaypoint].position, Time.deltaTime * 100000));

        //Debug.Log(angle);
        //if (Mathf.Abs(angle) < 90)
        //{
            transform.position = transform.position + transform.TransformDirection(Vector3.forward * force);
        //}

        //GetComponent<Rigidbody>().AddForce(transform.TransformVector(Vector3.forward * force));

    }

    
}
