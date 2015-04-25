using UnityEngine;
using System.Collections;

public class Element : MonoBehaviour 
{
	public bool percentage;

	public Sprite[] numberTextures;
	public Sprite [] Vegtables;
	private string type;
	public int value;

	void Start () {

		percentage = Random.value <.20;

		for (int i = 0; i<numberTextures.Length; i++) 
		{
			if(percentage)
			{
				loadTexture(i);
			}
			else 
				loadTexture(Random.Range(0,i));
		}

	

	}
	public void loadTexture(int counter){

		GetComponent<SpriteRenderer> ().sprite = numberTextures [counter];
		GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, 1f);
		type = numberTextures [counter].name;
		setValue (type);
	}

	public int getValue(){
		return value;
	}

	public void setValue(string type){
		if (type == "fifteen")
			value = 15;
		else if (type == "fourteen")
			value = 14;
		else if (type == "thirteen")
			value = 13;
		else if (type == "twelve")
			value = 12;
		else if (type == "eleven")
			value = 11;
		else if (type == "ten")
			value = 10;
		else if (type == "nine")
			value = 9;
		else if (type == "eight")
			value = 8;
		else if (type == "seven")
			value = 7;
		else if (type == "six")
			value = 6;
		else if (type == "five")
			value = 5;
	}
	

	void Update(){
	}

}
	


