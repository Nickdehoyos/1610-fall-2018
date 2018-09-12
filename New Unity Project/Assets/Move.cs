using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public CharacterController Character;
	public float Speed;
	public Vector3 MoveSpeed;
    public Vector3 RotateSpeed;
	
	// Update is called once per frame
	void Update ()
	{
		RotateSpeed.y = Speed * Input.GetAxis("Vertical");
		RotateSpeed *= Time.deltaTime;
		
		MoveSpeed.x = Speed*Input.GetAxis("Horizontal");
		MoveSpeed *= Time.deltaTime;

		Character.Move(MoveSpeed);
		
	}
}
