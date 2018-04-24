using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour {

    public float speed = 5f;

    private float previousHeight;

    private float mouseScroll = 0f;

	// Use this for initialization
	void Start ()
    {
        previousHeight = transform.position.y;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position -= new Vector3(0f, transform.position.y, 0f);
        transform.position += new Vector3(0f, previousHeight, 0f);

        mouseScroll = Input.GetAxis("Mouse ScrollWheel");

        if (mouseScroll != 0f)
        {
            transform.position += mouseScroll * speed * Vector3.up;
            previousHeight = transform.position.y;
        }
	}
}
