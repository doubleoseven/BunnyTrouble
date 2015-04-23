using UnityEngine;
using System.Collections;

public class numbersGUI : MonoBehaviour {
	[SerializeField]
	Texture2D[] listOfNumbers; //Four
	private int[] numbersSelected;
	Vector2 positionOne, positionTwo, positionThree, positionFour;
	Vector2 plusOne, plusTwo, plusThree, result, equal;
	[SerializeField]
	GUISkin _skin;
	//selectNumber number;
	//int numbersSelected;

	// Use this for initialization
	void Start () {
		numbersSelected = GameManager.instance.getSelectedNumbers();
		positionOne = new Vector2 (380, 105);
		positionTwo = new Vector2 (325, 105);
		positionThree = new Vector2 (270, 105);
		positionFour = new Vector2 (215, 105);

		plusOne = new Vector2 (358, 105);
		plusTwo = new Vector2 (303, 105);
		plusThree = new Vector2 (248, 105);

		equal = new Vector2 (155, 108);
		result = new Vector2 (109, 110);


	}

	public void OnGUI(){
		GUI.skin = _skin;
		GUI.TextArea(new Rect(Screen.width - positionOne.x, Screen.height - positionOne.y, 35, 35), numbersSelected[0].ToString(), 10, "box");
		GUI.TextArea(new Rect(Screen.width - plusOne.x, Screen.height - plusOne.y, 35, 35), "+", 10, "box");
		GUI.TextArea(new Rect(Screen.width - positionTwo.x, Screen.height - positionTwo.y, 35, 35), numbersSelected[1].ToString(), 10, "box");
		GUI.TextArea(new Rect(Screen.width - plusTwo.x, Screen.height - plusTwo.y, 35, 35), "+", 10, "box");
		GUI.TextArea(new Rect(Screen.width - positionThree.x, Screen.height - positionThree.y, 35, 35), numbersSelected[2].ToString(), 10, "box");
		GUI.TextArea(new Rect(Screen.width - plusThree.x, Screen.height - plusThree.y, 35, 35), "+", 10, "box");
		GUI.TextArea(new Rect(Screen.width - positionFour.x, Screen.height - positionFour.y, 35, 35), numbersSelected[3].ToString(), 10, "box");
		GUI.TextArea(new Rect(Screen.width - equal.x, Screen.height - equal.y, 35, 35), "=", 10, "box");
		GUI.TextArea(new Rect(Screen.width - result.x, Screen.height - result.y, 35, 35), GameManager.instance.getResult().ToString(), 10, "box");
	}
	
	// Update is called once per frame
	void Update () {

	}
}
