using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour {
    public GameObject Camera;
    public GameObject Player;
    public Vector3 Playerposition;
    private Vector3 CameraAway;

    void Start ()
    {
        CameraAway = new Vector3(0, 3, -5);
    }

	// Update is called once per frame
	void Update () {
        Playerposition = Player.transform.position;
        Camera.transform.position = Playerposition + CameraAway;
	}
}
