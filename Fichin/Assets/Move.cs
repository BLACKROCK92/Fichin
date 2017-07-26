using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
           GetComponent<Rigidbody>().AddForce(Vector3.up * 35);
            GetComponent<Rigidbody>().AddForce(Vector3.forward * 10);
        }
    }
}
