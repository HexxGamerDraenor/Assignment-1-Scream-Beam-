using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class TouchInput : MonoBehaviour {
    public float moveSpeed = 20f;
    public Joystick joy;
    
    void Update() {

        //PC input controls FOR TESTING WITHOUT ANDROID DEVICE
        if (joy.Horizontal != 0 || joy.Vertical != 0)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2
                (joy.Horizontal * moveSpeed, joy.Vertical * moveSpeed));
        }
	}
}
