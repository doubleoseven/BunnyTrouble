using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	public int count=0;

	public void update(){

		if (gameObject.transform.position.x == -3.0f) {
			//GameManager.instance.count = +1;
			count = +1;
			if (count == 5)
				Application.LoadLevel ("gameOver");
		}
	}
		
}
