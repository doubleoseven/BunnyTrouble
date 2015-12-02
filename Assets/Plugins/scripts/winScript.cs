using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class winScript : MonoBehaviour {
	
	private int bunniesLeft; 
	Text text;  

	void Awake () {
		text = GetComponent <Text> ();
		bunniesLeft = 9;
	}
	
	// Update is called once per frame
	void Update () {
		//Display the number of bunnies on screen.
		bunniesLeft = EnemyManager._instance.totalEnemy - GameManager.instance.bunniesSaved;
		text.text = " " + bunniesLeft;
	}


}
