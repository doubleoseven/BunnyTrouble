using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public int crossingLine = -2;

	void Start()
	{
		//crossingLine = Screen.width / 2 - 5; 
	}

	public void Update(){

		if (((int)gameObject.transform.position.x) == crossingLine) {
			
			GameManager.instance.bunniesCrossedOver++;
			Destroy(gameObject);
			/*
            if (GameManager.instance.count == 5){
                Application.LoadLevel ("gameOver");} */
		}
	}
		
}
