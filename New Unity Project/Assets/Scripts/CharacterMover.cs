using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{

	private CharacterController controller;
	
	public float Gravity = 9.81f;
	public float MoveSpeed = 3.0f;
	public float JumpSpeed = 10.0f;
	
	private Vector3 position;
	
	
	// Use this for initialization
	void Start ()
	{
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (controller.isGrounded)
		{
			position.Set(MoveSpeed*Input.GetAxis("Vertical"), 0, 0);
			position = transform.TransformDirection(position);
			
			if (Input.GetButton("Jump"))
			{
				position.y = JumpSpeed;
			}

		}
		position.y -= Gravity * Time.deltaTime;
		controller.Move(position * Time.deltaTime);
	}
}
