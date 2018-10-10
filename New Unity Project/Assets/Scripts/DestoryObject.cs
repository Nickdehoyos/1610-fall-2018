using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryObject : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds(5);
		Destroy(gameObject);
	}

	private void OnCollisionStay(Collision other)
	{		
		Destroy(other.gameObject);

		Destroy(gameObject);
	}
}
