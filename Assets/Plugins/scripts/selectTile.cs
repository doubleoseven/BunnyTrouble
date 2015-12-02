using UnityEngine;
using System.Collections;

[RequireComponent (typeof(NumberTexture))]
public class selectTile : MonoBehaviour {

	private Pause pauseScript;
	// Checks to see if the current tile is selected
	public bool currentSelected;

	// Checks if a plant has been planted on the current tile
	public bool vegtablePlanted;

	// A refrence to the Element class
	NumberTexture numberTextureScript;

	private Color selectedColor;
	private Color unSelectdColor;

	private SpriteRenderer spriteRenderer;

	void Start () {

		pauseScript = GameObject.FindGameObjectWithTag ("UI").GetComponent<Pause> ();

		numberTextureScript = GetComponent<NumberTexture> () as NumberTexture;
		spriteRenderer = GetComponent<SpriteRenderer> ();

		// Initial state of the tile
		currentSelected = false;
		vegtablePlanted = false;

		// Color values
		selectedColor = new Color (1f, 1f, 1f, .5f);
		unSelectdColor = new Color (1f, 1f, 1f, 1f);
	}

	private void OnMouseDown()
	{
		if (!pauseScript.Paused) {
			if (tileCanBeSelected ()) {
				GameManager.instance.tileSelected = true;
				currentSelected = true;
				// Set the value of the tile selected
				GameManager.instance.setTileSelectedValue (numberTextureScript.getValue ());
				GameManager.instance.tileObject = gameObject;
			} else if (tileCanBeDeSelected ()) {
				GameManager.instance.tileSelected = false;
				currentSelected = false;
				GameManager.instance.setTileSelectedValue (0);
				GameManager.instance.tileObject = null;
			}
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
		// The tile can only be selected/deselected if no plant has been planted on it
		return GameManager.instance.tileSelected == false && currentSelected == false && vegtablePlanted == false;
	}

	public bool tileCanBeDeSelected()
	{
		return GameManager.instance.tileSelected == true && currentSelected == true && vegtablePlanted == false;
	}
	

	void Update () {
	
		if (tileCanBeDeSelected()) {
			spriteRenderer.color = selectedColor;

		} else if (tileCanBeSelected()) {
			spriteRenderer.color = unSelectdColor;
		}

		if (GameManager.instance.tileSelected == false) {
			currentSelected = false;
		}
	}
}
