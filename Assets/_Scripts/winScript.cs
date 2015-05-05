using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class winScript : MonoBehaviour {

	public int bunniesToSave = 12;
	public int bunniesLeft; 
	Text text;  
	// Use this for initialization
	void Awake () {
		text = GetComponent <Text> ();
		bunniesLeft = 12;
	}
	
	// Update is called once per frame
	void Update () {
		bunniesLeft = bunniesToSave - GameManager.instance.bunniesSaved;
		text.text = "Bunnies Left: " + bunniesLeft;
		if (GameManager.instance.bunniesSaved == bunniesToSave) {
			Application.LoadLevel(6);
		}
	
	}
}
