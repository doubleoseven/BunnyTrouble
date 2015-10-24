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
		if (GameManager.instance.plantSelected == false && currentSelected == false && 
			GameManager.instance.tileSelected == true && GameManager.instance.getResult () > 0) 
		{
			soundEffectsManager._instance.playButtonClick2 ();
			GameManager.instance.plantSelected = true;
			currentSelected = true;
			GameManager.instance.setPlantType (gameObject.name);
			Debug.Log (gameObject.name);

		} else if (GameManager.instance.plantSelected == true && currentSelected == true)
		{
			soundEffectsManager._instance.playButtonClick2 ();
			Debug.Log (gameObject.name);
			GameManager.instance.plantSelected = false;
			currentSelected = false;
			GameManager.instance.setPlantType (null);
		}
	}

	void Update () {

		if (GameManager.instance.tileSelected == false) {
			GetComponent<Image> ().color = regularColor;
			currentSelected = false; 
			GameManager.instance.setPlantType (null);
			GameManager.instance.plantSelected = false;
		}

	}

	public bool IsCurrentSelected()
	{
		return currentSelected;
	}
}
