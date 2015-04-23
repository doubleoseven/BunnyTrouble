using UnityEngine;
using System.Collections;

public class numbersGUI : MonoBehaviour {
	[SerializeField]
	Texture2D[] numberSelected; //Four
	selectNumber number;
	int numbersSelected;

	// Use this for initialization
	void Start () {
		/*
			numbersSelected  = number.getNumberSelected;
			*/
	}

	public void OnGUI(){

		if (numbersSelected == 1) {
			GUI.DrawTexture(new Rect(20, 50, 100, 100), numberSelected[1]);
	     }
	}
	
	// Update is called once per frame
	void Update () {
	

	}
}
