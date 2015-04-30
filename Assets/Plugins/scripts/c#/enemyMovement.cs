using UnityEngine;
using System.Collections;

public class enemyMovement : MonoBehaviour {
//CharacterController controller;
	public float speed ;


	//bool a = GameObject.Find ("bunny").GetComponent<bunnyHealth> ().move;

	void Update () {
		//if(a==true)
		transform.Translate(-Vector2.right*speed*(Time.deltaTime));

	}
}
