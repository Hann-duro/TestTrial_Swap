using System.Collections;
using UnityEngine;
using UnityEngine.Animations;

public class WaypointMover : MonoBehaviour
{
    public Transform waypoint;
    public float moveSpeed = 2f;
    public float waitTime =2f;
    public bool loopWaypoints =  true;

    private Transform[] waypoints;
    private int currentWaypointsIndex;
    private bool isWaiting;

    void Start()
    {
        waypoints = new Transform[waypoint.childCount];
        for(int i = 0; i < waypoint.childCount; i++)
        {
            waypoints[i] = waypoint.GetChild(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isWaiting)
        {
            return;
        }
        MoveToWaypoint();
    }

    void MoveToWaypoint()
    {
        Transform target = waypoints[currentWaypointsIndex];
        transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        if(Vector2.Distance(transform.position, target.position) < 0.1f)
        {
            StartCoroutine(WaitAtWaypoint());
        }
    }

    IEnumerator WaitAtWaypoint()
    {
        isWaiting = true;
        yield return new WaitForSeconds(waitTime);

        currentWaypointsIndex = loopWaypoints ? (currentWaypointsIndex + 1) %waypoints.Length : Mathf.Min(currentWaypointsIndex + 1, waypoints.Length - 1);

        isWaiting = false;
    }
}
