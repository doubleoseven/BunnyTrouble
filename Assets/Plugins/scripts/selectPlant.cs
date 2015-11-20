using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class selectPlant : MonoBehaviour {

	private bool currentSelected;
	private bool canBeSelected = true;
	private Image image;

	Color regularColor;
	Color alphaColor;

	void Awake () {
		currentSelected = false;
		regularColor = new Color (1f, 1f, 1f, 1f);
		alphaColor = new Color (1f, 1f, 1f, .5f);
		image = GetComponent<Image> ();
	}
	
	public void plantSelect(){

		if (canCurrentPlantBeSelected() && AreOtherConditionsMet()) 
		{
			SoundEffectsManager._instance.playButtonClick2 ();
			GameManager.instance.plantSelected = true;
			currentSelected = true;
			GameManager.instance.setPlantType (gameObject.name);
			image.color = alphaColor;
//			Debug.Log (gameObject.name);

		} else if (canCurrentPlantBeDeSelected())
		{
			SoundEffectsManager._instance.playButtonClick2 ();
//			Debug.Log (gameObject.name);
			GameManager.instance.plantSelected = false;
			currentSelected = false;
			GameManager.instance.setPlantType (null);
			image.color = regularColor;
		}
	}

	public bool canCurrentPlantBeSelected()
	{
		return GameManager.instance.plantSelected == false && currentSelected == false && canBeSelected == true;
	}

	public bool canCurrentPlantBeDeSelected()
	{
		return GameManager.instance.plantSelected == true && currentSelected == true && canBeSelected == true;
	}

	public bool AreOtherConditionsMet()
	{
		return GameManager.instance.tileSelected && GameManager.instance.getResult () > 0;
	}

	void Update () {

		if (GameManager.instance.tileSelected == false) {
			image.color = regularColor;
			currentSelected = false; 
			GameManager.instance.setPlantType (null);
			GameManager.instance.plantSelected = false;
		} // We only want to do this once whenever certain condiitons are done. like unselecting a tile

	}

	public bool IsCurrentSelected()
	{
		return currentSelected;
	}

	public bool CanBeSelected
	{
		get{return canBeSelected;}
		set{canBeSelected = value;}
	}
}
