using UnityEngine;
using System.Collections;

public class enemyMovement : MonoBehaviour {
	CharacterController controller;
	public float speed = .02f;
	 bool dir1= true;



	void Start () 
	{
		controller = GetComponent<CharacterController>();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (dir1) 
		{
			transform.Translate(-Vector2.right*speed*Time.deltaTime);
		}
	}
}
