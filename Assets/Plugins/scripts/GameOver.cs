using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	public int count=0;

	public void update(){

		if (this.gameObject.transform.position.x == -3.0f) {
			//GameManager.instance.count = +1;
			GameManager.instance.bunniesCrossedOver+=1;
			Destroy(gameObject);
			if (GameManager.instance.bunniesCrossedOver == 5)
				Application.LoadLevel ("gameOver");
		}
	}
		
}
