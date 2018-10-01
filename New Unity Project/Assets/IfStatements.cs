using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{

	public bool LightOn;
	public string Password;
	public int A, B, C;
	
	public NameId Lock, Key;
	public FloatData WizardPower, PawnPower;
	
	void Update ()
	{

		if (Lock == Key)
		
		{
			print("Open Door");
		}
		
		if (WizardPower.Value > PawnPower.Value)
		{
			print("Wizard wins!");
		}
		else
		{
			print("Pawn Wins!");
		}
		if (LightOn)
		{
			print("The light is on.");
		}
		else
		{
			print("The light is off.");
		}

		if (Password == "OU812")
		{
			print("You are correct.");
		}
		else
		{
			print("The way is shut.");
		}

		if (C == A + B)
		{
			print(C);
		}
		
	}
	
	
}
