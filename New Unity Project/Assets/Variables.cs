﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{

	public bool IsAWizard;
	public bool IsAWitch;

	
	
	public int AmmoCount = 100;
	public int InventoryCount;

	public float Health = 1.0f;
	public float Money;

	public string PlayerName;
	public string Team = "Wolves";

	public Vector3 Location;
	
	
	
	
	// Use this for initialization
	void Start () {
		print(PlayerName);
		print("has");
		print("$"+Money);
		
		if (IsAWizard)
		{
			print(PlayerName + " Is a Wizard.");
			
		}

		if (IsAWitch)
		{
			print(PlayerName + " Is a Witch.");
		}

		if (IsAWitch)
		{
			transform.position = Location;
		}
	}
	
	
	// Update is called once per frame
	void Update ()
	{
	



	}
}
