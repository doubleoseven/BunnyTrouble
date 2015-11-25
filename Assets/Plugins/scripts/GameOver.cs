using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	GameObject EnemySpawner;

	public int crossingLine = -2;

	void Start()
	{
		EnemySpawner = GameObject.FindGameObjectWithTag ("EnemyManager");
		//crossingLine = Screen.width / 2 - 5; 
	}

	void removeMe ()
	{
		if (EnemySpawner != null) 
		{
			EnemySpawner.BroadcastMessage ("killEnemy");
		}
	}

	public void Update(){

		if (((int)gameObject.transform.position.x) == crossingLine) {
			
			GameManager.instance.bunniesCrossedOver++;
			removeMe();
			Destroy(gameObject);
			/*
            if (GameManager.instance.count == 5){
                Application.LoadLevel ("gameOver");} */
		}
	}
		
}
