using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Route : MonoBehaviour
{
    // public int numberOfRoute = 1;
    public GameObject player;
    public GameObject finish;
    public GameObject[] route;
    public int counter = 0;
    public int totalRoute;
    public int currentRouteTarget;
    public GameObject[] routeHintNow;
    public GameObject[] routeHintNext;
    public GameObject routeHintFinish;
    public GameObject UIController;

    public GameObject finishScreen;
    string forCount;

    // Start is called before the first frame update
    void Start()
    {
        totalRoute = route.Length;
        Debug.Log("total route = " + totalRoute);
        routeHintNow = new GameObject[route.Length];
        routeHintNext = new GameObject[route.Length];
        for (int i = 0; i < route.Length; i++)
        {
            routeHintNow[i] = route[i].transform.Find("routeHintNow").gameObject;
            routeHintNext[i] = route[i].transform.Find("routeHintNext").gameObject;
        }
        routeHintFinish = finish.transform.Find("routeHintFinish").gameObject;
        routeHintNow[0].active = true;
        routeHintNext[1].active = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TriggerRoute(string routeNumber)
    {
        if (route[counter].GetComponent<RouteTrigger>().isTriggered)
        {
            Debug.Log(route[counter].name + " is triggered");

            routeHintNow[counter].active = false;
            if (counter < route.Length - 1)
            {
                routeHintNext[counter + 1].active = false;
            }
            if (counter < route.Length - 2)
            {
                routeHintNow[counter + 1].active = true;
                routeHintNext[counter + 2].active = true;
            }
            else if (counter < route.Length - 1)
            {
                routeHintNow[counter + 1].active = true;
                routeHintFinish.active = true;
            }
            Debug.Log("counter: " + (counter+1) + "\nRoute " + route[counter].name);
            string temp = string.Join("", gameObject.name.Split("Route".ToCharArray()));
            if ((counter+1).ToString() == routeNumber){
                counter++;
            }
        }
        currentRouteTarget = counter;
        Debug.Log("current route target = " + (currentRouteTarget + 1));
    }

    public void TriggerFinish()
    {
        Debug.Log("Counter = " + counter);
        if (counter == route.Length)
        {
            Debug.Log("Finish. yey!!");
            player.GetComponent<VehicleControl>().activeControl = false;
            finishScreen.active = true;
            finishScreen.GetComponent<FinishScreenScript>().finishRace = true;
            finishScreen.GetComponent<FinishScreenScript>().startRace = false;
            finishScreen.GetComponent<FinishScreenScript>().FinishRace();
            UIController.active = false;
        }
    }
}
