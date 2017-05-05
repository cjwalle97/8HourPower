using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {
    public GameObject Player;
    private Collider body;
    private Rigidbody rb;
    private Vector3 Force;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public float uForce = 3f;
    // Update is called once per frame
    void Update () {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        if (Input.GetKeyDown("space"))
            rb.AddForce(Vector3.up * uForce);

        float vForce = v * 3;
        float hForce = h * 3;
        
        
        Force = new Vector3(hForce, rb.velocity.y, vForce);
        rb.velocity = Force;
        if (Input.GetKeyDown(("g")))
        {
            Application.Quit();
        }
    }
}
