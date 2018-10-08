using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public float Speed;
	public float MoveSpeed = 10f;
    public float TurnSpeed = 50f;
		
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey(KeyCode.UpArrow))
			transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
		if (Input.GetKey(KeyCode.DownArrow))
			transform.Translate(-Vector3.forward * MoveSpeed * Time.deltaTime);
		if (Input.GetKey(KeyCode.LeftArrow))
			transform.Rotate(-Vector3.up, TurnSpeed * Time.deltaTime);
		if (Input.GetKey(KeyCode.RightArrow))
			transform.Rotate(Vector3.up, TurnSpeed * Time.deltaTime);
			
		
	}		
}
