using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	//public int count=0;

	public void Update(){

		if (((int)gameObject.transform.position.x) == 0) {
			
			GameManager.instance.bunniesCrossedOver++;
			Destroy(gameObject);
			/*
            if (GameManager.instance.count == 5){
                Application.LoadLevel ("gameOver");} */
		}
	}
		
}
