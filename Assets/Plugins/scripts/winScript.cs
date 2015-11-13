using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class winScript : MonoBehaviour {

	public int bunniesToSave = 9;
	public int bunniesLeft; 
	Text text;  

	void Awake () {
		text = GetComponent <Text> ();
		bunniesLeft = 9;
	}
	
	// Update is called once per frame
	void Update () {
		bunniesLeft = bunniesToSave - GameManager.instance.bunniesSaved;
		text.text = " " + bunniesLeft;
		if (bunniesLeft <= 0) {
			Application.LoadLevel(6);
		}
	
	}
}
