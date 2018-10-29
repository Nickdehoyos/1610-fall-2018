using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwitchStatements : MonoBehaviour
{
	public GameStates.States GameState;
	public UnityEvent Starting, Loading, Playing, Dying, Ending;
	
	// Update is called once per frame
	void Update () {
		
		switch (GameState)
		{
			case GameStates.States.Starting:
				print("We are starting the game");
				break;
			
			case GameStates.States.Loading:
				print("We are loading the game");
				break;
			
			case GameStates.States.Playing:
				print("We are playing the game");
				break;
			
			case GameStates.States.Ending:
				print("We are ending the game");
				break;
		}
	}
}
