using UnityEngine;
using System.Collections;

public class selectTile : MonoBehaviour {
	public bool currentSelected;
	public bool vegtablePlanted;
	Element element;
	[SerializeField]
	Sprite carrot;
	[SerializeField]
	Sprite turnip;


	//private string tileSelectedName;

	// Use this for initialization
	void Start () {
		element = GetComponent<Element> () as Element;
		currentSelected = false;
		vegtablePlanted = false;
	
	}

	private void OnMouseDown()
	{
		if (GameManager.instance.tileSelected == false && currentSelected == false && vegtablePlanted == false) {
			GameManager.instance.tileSelected = true;
			currentSelected = true;
			GameManager.instance.setTileSelectedValue(element.getValue());
			//mouseOver = element.getSprite;
			GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, .5f);
		} 
		else if(GameManager.instance.tileSelected == true&& currentSelected == true && vegtablePlanted == false)
		{
			GameManager.instance.tileSelected = false;
			currentSelected = false;
			GameManager.instance.setTileSelectedValue(0);
			GetComponent<SpriteRenderer>().color = new Color (1f, 1f, 1f, 1f);
		}
		//element.loadTexture (mouseOver);
	}

	public bool getCurrentSelected(){
		return currentSelected;
	}

	public void setCurrentSelected(bool selected){
		currentSelected = selected;
	}

	public bool getVegtablePlanted(){
		return vegtablePlanted;
	}

	public void setVegtablePlanted(bool planted){
		vegtablePlanted = planted;
	}


	public void Plant()
	{
		if (GameManager.instance.tileSelected) {
				if(GameManager.instance.plantSelected){
					if(GameManager.instance.getResult() == GameManager.instance.getTileSelectedValue()){
						if(GameManager.instance.getPlantType() == "carrot"){
							GameManager.instance.carrotPlanted = true;
							//vegtablePlanted = true;
							//GameManager.instance.tileSelected = false;
						}
						else if(GameManager.instance.getPlantType() == "turnip"){
							GameManager.instance.turnipPlanted = true;
						}
					} else Debug.Log ("Result not correct");
				} else Debug.Log("Plant not selected");
		} else Debug.Log ("Tile not selected");
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.instance.tileSelected == true && currentSelected == true) {
			GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, .5f);
		} else if (GameManager.instance.tileSelected == false && currentSelected == false && vegtablePlanted == false) {
			GetComponent<SpriteRenderer>().color = new Color (1f, 1f, 1f, 1f);
		}
	
	}
}
