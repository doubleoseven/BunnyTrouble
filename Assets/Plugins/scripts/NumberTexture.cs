using UnityEngine;
using System.Collections;

[RequireComponent (typeof(selectTile))]
public class NumberTexture : MonoBehaviour 
{
	// The numbers that will be used in the level
	public Sprite[] numberTextures;
	
	// The number that is on the tile in form of a String
	private string type;

	//A random number which will set the randomness of the numbers.
	private bool percentage;

	// the converted string into a integer
	private int value;
	private SpriteRenderer spriteRenderer;

	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer> ();
		percentage = Random.value <.35;
		loadNumbers ();
	}

	public void loadNumbers() 
	{
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
		spriteRenderer.sprite = numberTextures [counter];
		spriteRenderer.color = new Color (1f, 1f, 1f, 1f);
		type = numberTextures [counter].name; 
		setValue (type);
	}


	public void setValue(string type)
	{

		switch (type) 
		{
		case "fifteen":
			value = 15;
			break;
		case "fourteen":
			value = 14;
			break;
		case "thirteen":
			value = 13;
			break;
		case "tweleve":
			value = 12;
			break;
		case "eleven":
			value = 11;
			break;
		case "ten":
			value = 10;
			break;
		case "nine":
			value = 9;
			break;
		case "eight":
			value = 8;
			break;
		case "seven":
			value = 7;
			break;
		case "six":
			value = 6;
			break;
		case "five":
			value = 5;
			break;
		case "four":
			value = 4;
			break;
		case "three":
			value = 3;
			break;
		}
	}

	public int getValue(){
		return value;
	}
}
	


