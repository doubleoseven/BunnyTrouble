using UnityEngine;
using System.Collections;

public class enemyMovement : MonoBehaviour {

	public float speed ;

	void Update () {
		if (!GameManager.instance.pause) {

			transform.Translate (-Vector2.right * speed * (Time.deltaTime));
		}
	}
}
