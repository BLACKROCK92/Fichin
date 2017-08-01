using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

    void OnTriggerEnter (Collider other)
    {
        print(other.name); 
        Destroy(other.gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        print(collision.transform.name);
    }
}
