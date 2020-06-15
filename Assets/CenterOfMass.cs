using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterOfMass : MonoBehaviour
{
    private Rigidbody rb; 

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {

        rb.centerOfMass = new Vector3(0,0,0);
    }
}
