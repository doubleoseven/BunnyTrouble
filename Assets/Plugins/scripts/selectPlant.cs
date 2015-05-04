using UnityEngine;
using System.Collections;

public class selectPlant : MonoBehaviour {
	private bool currentSelected;

	private void OnMouseDown(){
		if (GameManager.instance.plantSelected == false && currentSelected == false && 
		    GameManager.instance.tileSelected == true && GameManager.instance.getResult()>0) {

			GameManager.instance.plantSelected = true;
			currentSelected = true;
			GameManager.instance.setPlantType(gameObject.name);
			GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, .5f);
			Debug.Log (gameObject.name);

		} else if(GameManager.instance.plantSelected == true && currentSelected == true)
		{
			Debug.Log (gameObject.name);
			GameManager.instance.plantSelected = false;
			currentSelected = false;
			GameManager.instance.setPlantType(null);
			GetComponent<SpriteRenderer>().color = new Color (1f, 1f, 1f, 1f);
		}

	}
	// Use this for initialization
	void Start () {
		currentSelected = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (GameManager.instance.tileSelected == false) {
			GetComponent<SpriteRenderer>().color = new Color (1f, 1f, 1f, 1f);
			currentSelected = false; 
			GameManager.instance.setPlantType(null);
			GameManager.instance.plantSelected = false;
		}
	
	}
}
