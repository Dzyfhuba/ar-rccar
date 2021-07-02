using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTrigger : MonoBehaviour
{
	public GameObject[] route = new GameObject[1];
	[Header("Centang Jika ingin tipe sirkuit")]
	public bool setEnableCircuit;
    // Start is called before the first frame update
	void Start()
	{

	}

    // Update is called once per frame
	void Update()
	{

	}
	public void OnTriggerEnter(Collider col){
		for(int i = 0; i < route.Length;){
			if(col.gameObject.name == route[i].name){
				i++;
				Debug.Log(col.gameObject.name);
			}
		}
	}
}
