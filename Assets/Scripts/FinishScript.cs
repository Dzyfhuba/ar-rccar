using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScript : MonoBehaviour
{
    public Route route;
    // Start is called before the first frame update
    void Start()
    {
        route = GameObject.FindGameObjectWithTag("Gameplay").GetComponent<Route>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.transform.parent.parent.tag == "Player")
        {
            route.TriggerFinish();
        }
    }
}
