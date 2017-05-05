using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {
    public GameObject Player;
    private Rigidbody rb;
    private Vector3 Force;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

	// Update is called once per frame
	void Update () {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        float vForce = v * 3;
        float hForce = h * 3;
        float uForce = 0;
        Force = new Vector3(hForce, uForce, vForce);
        rb.velocity = Force;
	}
}
