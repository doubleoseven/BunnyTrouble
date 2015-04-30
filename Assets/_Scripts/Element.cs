using UnityEngine;
using System.Collections;

public class Element : MonoBehaviour 
{
	public bool percentage;

	public Sprite[] numberTextures;
	public GameObject[] plants;

	private string type;
	public int value;

	public bool carrotPlanted;
	public bool turnipPlanted;

	selectTile tile;
	void Start () {
		tile = GetComponent<selectTile> ();
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

	public void loadVegtable(int index){
		GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, 0f);
		GameObject vegtale = Instantiate (plants [index], gameObject.transform.position, gameObject.transform.rotation) as GameObject;
		vegtale.transform.SetParent (gameObject.transform);
	}

	public int getValue(){
		return value;
	}

	public void setCarrotPlanted (bool planted){
		carrotPlanted = planted;
	}

	public void setTurnipPlanted(bool planted){
		turnipPlanted = planted;
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
	}

	public void setCurrentSelected(bool selected)
	{
		tile.setCurrentSelected (selected);
	}
	

	void Update(){
		if (GameManager.instance.carrotPlanted == true && tile.getCurrentSelected()) {
			loadVegtable (0);
			tile.setCurrentSelected(false);
			tile.setVegtablePlanted(true);
			GameManager.instance.tileSelected = false;
			GameManager.instance.carrotPlanted = false;
		} else if (GameManager.instance.turnipPlanted == true && tile.getCurrentSelected()) {
			loadVegtable(1);
			tile.setCurrentSelected(false);
			tile.setVegtablePlanted(true);
			GameManager.instance.tileSelected = false;
			GameManager.instance.turnipPlanted = false;
		}

		if (tile.getVegtablePlanted () == false) {
			GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, 1f);
		}
	}
}
	


