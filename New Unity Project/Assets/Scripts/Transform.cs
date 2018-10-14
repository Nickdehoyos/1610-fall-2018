using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform : MonoBehaviour
{
	public float MovementSpeed = 10f;
	public float TurnSpeed = 50f;
	public float Speed;
	
	
	// Update is called once per frame
	void Update()
	{
		if
			(Input.GetKey(KeyCode.UpArrow))

			transform.Translate(Vector3.forward * MovementSpeed * Time.deltaTime);

		if (Input.GetKey(KeyCode.DownArrow))
			
			transform.Translate(Vector3.back * MovementSpeed * Time.deltaTime);

		if (Input.GetKey(KeyCode.LeftArrow))
		
			transform.Rotate(Vector3.up * TurnSpeed * Time.deltaTime);

		if (Input.GetKey(KeyCode.RightArrow))
		
			transform.Rotate(Vector3.down * TurnSpeed * Time.deltaTime);
			
		
		
	}
	
	
}

