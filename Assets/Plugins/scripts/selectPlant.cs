using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class selectPlant : MonoBehaviour {

	private bool currentSelected;

	Color regularColor;

	void Awake () {
		currentSelected = false;
		regularColor = new Color (1f, 1f, 1f, 1f);
	}
	
	public void plantSelect(){

		if (canCurrentPlantBeSelected() == false && AreOtherConditionsMet()) 
		{
			SoundEffectsManager._instance.playButtonClick2 ();
			GameManager.instance.plantSelected = true;
			currentSelected = true;
			GameManager.instance.setPlantType (gameObject.name);
			Debug.Log (gameObject.name);

		} else if (canCurrentPlantBeSelected())
		{
			SoundEffectsManager._instance.playButtonClick2 ();
			Debug.Log (gameObject.name);
			GameManager.instance.plantSelected = false;
			currentSelected = false;
			GameManager.instance.setPlantType (null);
		}
	}

	public bool canCurrentPlantBeSelected()
	{
		return GameManager.instance.plantSelected && currentSelected;
	}

	public bool AreOtherConditionsMet()
	{
		return GameManager.instance.tileSelected && GameManager.instance.getResult () > 0;
	}

	void Update () {

		if (GameManager.instance.tileSelected == false) {
			GetComponent<Image> ().color = regularColor;
			currentSelected = false; 
			GameManager.instance.setPlantType (null);
			GameManager.instance.plantSelected = false;
		} // We only want to do this once whenever certain condiitons are done. like unselecting a tile

	}

	public bool IsCurrentSelected()
	{
		return currentSelected;
	}
}
