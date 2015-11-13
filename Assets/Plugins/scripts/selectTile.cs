﻿using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Element))]
public class selectTile : MonoBehaviour {

	// Checks to see if the current tile is selected
	public bool currentSelected;

	// Checks if a plant has been planted on the current tile
	public bool vegtablePlanted;

	// A refrence to the Element class
	Element element;
	private Color selectedColor;
	private Color unSelectdColor;
	void Start () {
		element = GetComponent<Element> () as Element;

		// Initial state of the tile
		currentSelected = false;
		vegtablePlanted = false;
		selectedColor = new Color (1f, 1f, 1f, .5f);
		unSelectdColor = new Color (1f, 1f, 1f, 1f);
	}

	private void OnMouseDown()
	{
		// The tile can only be selected/deselected if no plant has been planted on it

		if (tileCanBeSelected()) {
			GameManager.instance.tileSelected = true;
			currentSelected = true;
			// Set the value of the tile selected
			GameManager.instance.setTileSelectedValue(element.getValue());
			GameManager.instance.tileObject = gameObject;
		} 
		else if(tileCanBeDeSelected())
		{
			GameManager.instance.tileSelected = false;
			currentSelected = false;
			GameManager.instance.setTileSelectedValue(0);
			GameManager.instance.tileObject = null;
		}
	}

	// Setters and getters
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

	public bool tileCanBeSelected()
	{
		return GameManager.instance.tileSelected == false && currentSelected == false && vegtablePlanted == false;
	}

	public bool tileCanBeDeSelected()
	{
		return GameManager.instance.tileSelected == true && currentSelected == true && vegtablePlanted == false;
	}


	void Update () {

		if (tileCanBeDeSelected()) {
			GetComponent<SpriteRenderer> ().color = selectedColor;

		} else if (tileCanBeSelected()) {
			GetComponent<SpriteRenderer>().color = unSelectdColor;
		}

		if (GameManager.instance.tileSelected == false) {
			currentSelected = false;
		}
	
	}
}
