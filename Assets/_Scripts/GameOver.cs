using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	public int count=0;
	GameObject bunny = GameObject.Find("bunny(Clone)");

	public void update(){

		 if (((int)bunny.transform.position.x) == -3) {

			count++;
			if (count == 5){
				Application.LoadLevel ("gameOver");}
		}
	}
		
}
