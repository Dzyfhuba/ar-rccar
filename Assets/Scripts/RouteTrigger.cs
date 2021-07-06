using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouteTrigger : MonoBehaviour
{
    public bool isTriggered;
    public string routeNumber;
    public Route route;
    // Start is called before the first frame update
    void Start()
    {
        routeNumber = string.Join("", gameObject.name.Split("Route".ToCharArray()));
        route = GameObject.FindGameObjectWithTag("Gameplay").GetComponent<Route>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider col)
    {
        // Debug.Log("Triggered by " + col.gameObject.transform.parent.parent.tag);
        if (col.gameObject.transform.parent.parent.tag == "Player")
        {
            isTriggered = true;
            route.TriggerRoute();
        }
    }
}
