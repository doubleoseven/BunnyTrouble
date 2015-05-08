using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	//public int count= 0;
	//GameObject bunny = 

	public void Update(){
		//Debug.Log (gameObject.transform.position.x);
		if (((int)gameObject.transform.position.x) == -4) {

			GameManager.instance.count++;
			Destroy(gameObject);
			/*
			if (GameManager.instance.count == 5){
				Application.LoadLevel ("gameOver");} */
		}
	}
		
}
