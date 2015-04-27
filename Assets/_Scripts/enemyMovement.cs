using UnityEngine;
using System.Collections;

public class enemyMovement : MonoBehaviour {
//CharacterController controller;
	public float speed ;




	void Update () {
		transform.Translate(-Vector2.right*speed*(Time.deltaTime));

	}
}
