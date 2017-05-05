using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutofBounds : MonoBehaviour {

    public GameObject Startingpoint;
    
    void OnTriggerEnter(Collider other)
    {
        CompareTag("Player");
        other.transform.position = Startingpoint.transform.position; 
    }

}
