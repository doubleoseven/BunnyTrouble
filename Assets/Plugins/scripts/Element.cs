using UnityEngine;
using System.Collections;

[RequireComponent (typeof(selectTile))]
public class Element : MonoBehaviour 
{
	// The numbers that will be used in the level
	public Sprite[] numberTextures;
	// The plants that will be used in the level
	public GameObject[] plants;

	// The number that is on the tile in form of a String
	private string type;
	//A random number which will set the randomness of the numbers.
	private bool percentage;

	// the converted string into a integer
	private int value;

	selectTile tile;

	void Start () {

		tile = GetComponent<selectTile> ();
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

		GetComponent<SpriteRenderer> ().sprite = numberTextures [counter];
		GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, 1f);
		type = numberTextures [counter].name; 
		setValue (type);

	}
	public void plantVegtable(int index){
		GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, 0f);
		GameObject vegtable = Instantiate (plants [index], gameObject.transform.position, gameObject.transform.rotation) as GameObject;
		vegtable.transform.SetParent (gameObject.transform);
	}
	

	public void setValue(string type){
		if (type == "fifteen")
			value = 15;
		else if (type == "fourteen")
			value = 14;
		else if (type == "thirteen")
			value = 13;
		else if (type == "tweleve")
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
		else if (type == "four")
			value = 4;
		else if (type == "three")
			value = 3;
	}

	public int getValue(){
		return value;
	}
	
	void Update(){
		if (GameManager.instance.vegtablePlanted == "carrot" && tile.getCurrentSelected()) {
			plantVegtable (0);
			tile.setCurrentSelected(false);
			tile.setVegtablePlanted(true);
			GameManager.instance.tileSelected = false;
			GameManager.instance.vegtablePlanted = null;
		} else if (GameManager.instance.vegtablePlanted == "turnip" && tile.getCurrentSelected()) {
			plantVegtable(1);
			tile.setCurrentSelected(false);
			tile.setVegtablePlanted(true);
			GameManager.instance.tileSelected = false;
			GameManager.instance.vegtablePlanted = null;
		}
		else if (GameManager.instance.vegtablePlanted == "tomatoes" && tile.getCurrentSelected()) {
			plantVegtable(2);
			tile.setCurrentSelected(false);
			tile.setVegtablePlanted(true);
			GameManager.instance.tileSelected = false;
			GameManager.instance.vegtablePlanted = null;
		}
		else if (GameManager.instance.vegtablePlanted == "pumpkin" && tile.getCurrentSelected()) {
			plantVegtable(3);
			tile.setCurrentSelected(false);
			tile.setVegtablePlanted(true);
			GameManager.instance.tileSelected = false;
			GameManager.instance.vegtablePlanted = null;
		}
		if (tile.getVegtablePlanted () == false) {
			GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, 1f);
		}
	}
}
	


