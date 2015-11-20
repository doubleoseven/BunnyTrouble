using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class selectPlant : MonoBehaviour {

	private bool currentSelected;
	private bool canBeSelected = true;
	private Image image;
	private Plant plantScript;

	Color regularColor;
	Color alphaColor;

	void Awake () {
		currentSelected = false;
		regularColor = new Color (1f, 1f, 1f, 1f);
		alphaColor = new Color (1f, 1f, 1f, .5f);
		image = GetComponent<Image> ();
		plantScript = GetComponent<Plant> ();
	}
	
	public void plantSelect(){

		if (canBeSelected) {
			if (AreOtherConditionsMet ()) {
				GameManager.instance.plantSelected = true;
				currentSelected = true;
				//GameManager.instance.setPlantType (gameObject.name);

				Plant ();
				UnselectPlant ();
			} 
		}
	}
	

	void Plant()
	{
		if (GameManager.instance.correct) 
		{
			SoundEffectsManager._instance.playCorrect ();
			GameManager.instance.vegtablePlanted = gameObject.name;
			GameManager.instance.isVegtablePlanted = true;
			plantScript.callCountDown ();
		} else {
			SoundEffectsManager._instance.playWrong ();
			Debug.Log ("Result not correct");
			GameManager.instance.tileSelected = false;
		}
	}

	void UnselectPlant()
	{
		GameManager.instance.plantSelected = false;
		currentSelected = false;
	}
	

	public bool AreOtherConditionsMet()
	{
		return GameManager.instance.tileSelected && GameManager.instance.getResult () > 0;
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
