using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        // transform position of camera - transform position of player
        offset = transform.position - player.transform.position;
	}
	
	// LateUpdate is called once per frame AND guaranteed to run after all items have been processed in update
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
