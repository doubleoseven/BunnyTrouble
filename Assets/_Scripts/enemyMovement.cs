using UnityEngine;
using System.Collections;

public class enemyMovement : MonoBehaviour {
//CharacterController controller;
	public float speed ;


	//bool a = GameObject.Find ("bunny").GetComponent<bunnyEating> ().move;

	void Update () {

		transform.Translate(-Vector2.right*speed*(Time.deltaTime));

	}
}
