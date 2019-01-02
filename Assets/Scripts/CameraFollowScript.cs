using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour {

    public Transform cameraPosition;
    public float smoothmoveSpeed =0.3f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(cameraPosition.position.y > transform.position.y)
        {
            Vector3 newPosition = new Vector3(transform.position.x, cameraPosition.position.y,transform.position.z);
            transform.position = newPosition;
        }
    }
}
