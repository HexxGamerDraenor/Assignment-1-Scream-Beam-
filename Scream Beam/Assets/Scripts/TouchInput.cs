using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class TouchInput : MonoBehaviour {
    public float moveSpeed = 20f;

    
    void Update() {
        //Touch input controls
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Camera.main.ScreenToWorldPoint(touch.position);
        }

        //PC input controls FOR TESTING WITHOUT ANDROID DEVICE
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2
                (Input.GetAxis("Horizontal") * moveSpeed, 
                Input.GetAxis("Vertical") * moveSpeed));
        }
	}
}
