using UnityEngine;
using System.Collections;

public class enemyMovement : MonoBehaviour 
{
//CharacterController controller;

	public float speed;


	//Min = 0.4 Max = 1.5

	void Update () 
	{
		//If the player is not concentrating, then increase the speed movement
//		if (DeviceManager.instance.beta * 10 < 12) 
//		{
//			if (speed >= 1.5)
//			{
//				speed = 1.5f;
//			} else
//				speed += 0.01f;
//		} else 
//		{ //Else decrease the speed movement
//			if (speed <= 0.4)
//			{
//				speed = 0.4f;
//			} else 
//				speed -= 0.1f;
//		}


		if (GetComponent<bunnyHealth> ().Dead != true) 
		{
			if(GameManager.instance.paused == false)
			{
				transform.Translate (-Vector2.right * speed * (Time.deltaTime));
			}
		}

	}
}
