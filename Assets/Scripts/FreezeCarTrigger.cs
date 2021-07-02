using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeCarTrigger : MonoBehaviour
{
    Rigidbody p_rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        p_rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FreezePosition(bool active){
        if (active){
            p_rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
        } else {
            p_rigidbody.constraints = RigidbodyConstraints.None;
        }
    }
}
