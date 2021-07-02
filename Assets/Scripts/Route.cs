using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Route : MonoBehaviour
{
	// public int numberOfRoute = 1;
    public Collider[] route = new Collider[1];


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // int loop = 0;

        // foreach(Collider r in route){
        //     loop++;
        //     if(r.isTrigger){
        //         Debug.Log("route " + loop + " : " + r.isTrigger);
        //     }
        // }
    }

    public void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Player"){
            Debug.Log("route ");
        }
    }
}
