using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class move_obstacle : MonoBehaviour
{
    public float speed;
    Vector3 targetpos;

    public GameObject ways;
    public Transform[] waypoints;
    int pointindex;
    int pointcount;
    int direction = 1;


    private void Awake()
    {
        waypoints = new Transform[ways.transform.childCount];
        for(int i = 0; i<ways.gameObject.transform.childCount;i++)
        {
            waypoints[i] = ways.transform.GetChild(i).gameObject.transform;
        }
    }

    private void Start()
    {
        pointcount = waypoints.Length;
        pointindex = 1;
        targetpos = waypoints[pointindex].transform.position;

    }

    private void Update()
    {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetpos, step);

        if (transform.position == targetpos)
        {
            NextPoint();
        }
    }
    
    void NextPoint()
    {
        if (pointindex == pointcount - 1)
        {
            direction = -1;
        }

        if (pointindex == 0)
        {
            direction = 1;
        }

        pointindex += direction;
        targetpos = waypoints[pointindex].transform.position;
    }
}
