using UnityEngine;
using System.Collections;

public class selectTile : MonoBehaviour {
	public bool currentSelected = false;
	public bool vegtablePlanted = false;

	// Use this for initialization
	void Start () {
	
	}

	private void OnMouseDown()
	{
		if (GameManager.instance.tileSelected == false && currentSelected == false && vegtablePlanted == false) {
			GameManager.instance.tileSelected = true;
			currentSelected = true;
			//mouseOver = element.getSprite;
			GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, .5f);
		} 
		else if(GameManager.instance.tileSelected == true&& currentSelected == true && vegtablePlanted == false)
		{
			GameManager.instance.tileSelected = false;
			currentSelected = false;
			GetComponent<SpriteRenderer>().color = new Color (1f, 1f, 1f, 1f);
		}
		//element.loadTexture (mouseOver);
	}

	/*
	public void OnMouseUp()
	{
		selected = false;
		GetComponent<SpriteRenderer>().color = new Color (1f, 1f, 1f, 1f);
	} */
	// Update is called once per frame
	void Update () {
		if (GameManager.instance.tileSelected == true && currentSelected == true) {
			GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, .5f);
		} else if (GameManager.instance.tileSelected == false && currentSelected == false && vegtablePlanted == false) {
			GetComponent<SpriteRenderer>().color = new Color (1f, 1f, 1f, 1f);
		}
	
	}
}
