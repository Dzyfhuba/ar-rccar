using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Route : MonoBehaviour
{
	// public int numberOfRoute = 1;
    public GameObject[] route;
    public int counter = 0;
    public int totalRoute;

    public int currentRouteTarget;

    // Start is called before the first frame update
    void Start()
    {
        totalRoute = route.Length;
        Debug.Log("total route = " + totalRoute);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TriggerRoute()
    {
        if (route[counter].GetComponent<RouteTrigger>().isTriggered)
        {
            counter++;
            Debug.Log(route[counter-1].name + " is triggered");
        }
        if(counter == totalRoute)
        {
            Debug.Log("go to finish line");
        }
        currentRouteTarget = counter;
        Debug.Log("current route target = " + currentRouteTarget+1);
    }
}
