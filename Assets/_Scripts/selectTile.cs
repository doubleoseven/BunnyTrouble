using UnityEngine;
using System.Collections;

public class selectTile : MonoBehaviour {
	public bool currectSelected = false;
	Element element;
	public Sprite mouseOver;

	// Use this for initialization
	void Start () {
	
	}

	public void OnMouseDown()
	{
		if (GameManager.instance.tileSelected == false && currectSelected == false) {
			GameManager.instance.tileSelected = true;
			currectSelected = true;
			//mouseOver = element.getSprite;
			GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, .5f);
		} 
		else if(GameManager.instance.tileSelected == true&& currectSelected == true)
		{
			GameManager.instance.tileSelected = false;
			currectSelected = false;
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
	
	}
}
