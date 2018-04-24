using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTestScript : MonoBehaviour {

    private float mouseScroll = 0f;
    private Vector2 mouseDelta = new Vector2(0f, 0f);
    
    // Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        mouseScroll = Input.GetAxis("Mouse ScrollWheel");
        mouseDelta[0] = Input.GetAxis("Mouse X");
        mouseDelta[1] = Input.GetAxis("Mouse Y");

        if (mouseScroll != 0f)
            Debug.Log("Mouse Scroll: " + mouseScroll);

        if (mouseDelta[0] != 0f)
            Debug.Log("Mouse X: " + mouseDelta[0]);

        if (mouseDelta[1] != 0f)
            Debug.Log("Mouse Delta: " + mouseDelta[1]);

        //if (mouseDelta != Vector2.zero)
        //    Debug.Log("Mouse Delta: " + mouseDelta);
    }
}
