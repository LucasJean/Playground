using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public float speed = 5f;
    private Transform player;
    
    // Use this for initialization
	void Start ()
    {
        player = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.anyKey)
        {
            Vector3 movement;

            movement.x = Input.GetAxis("Horizontal");
            movement.z = Input.GetAxis("Vertical");
            movement.y = 0f;

            movement = movement.normalized;

            player.position += movement * Time.deltaTime * speed;
        }
	}
}
