using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	//public int count= 0;
	//GameObject bunny = 

	public void Update(){
		//Debug.Log (gameObject.transform.position.x);
		if (((int)gameObject.transform.position.x) == -5) {
			Destroy(gameObject);
			GameManager.instance.count+=1;
		}
	if (GameManager.instance.count == 5){
			Application.LoadLevel (5);} 
	}
		
}
