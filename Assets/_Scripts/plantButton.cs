using UnityEngine;
using System.Collections;

public class plantButton : MonoBehaviour {
	Element elem;

	public void plant(){

		if (GameManager.instance.tileSelected) {
			if(GameManager.instance.plantSelected){
				if(GameManager.instance.correct){
					if(GameManager.instance.getPlantType() == "carrot"){
						//if(soundEffectsManager._instance!=null)
						soundEffectsManager._instance.playCorrect();
						GameManager.instance.carrotPlanted = true;
					}
					else if(GameManager.instance.getPlantType() == "turnip"){
						//if(soundEffectsManager._instance!=null)
						soundEffectsManager._instance.playCorrect();
						GameManager.instance.turnipPlanted = true;
					}
				} else {
					//if(soundEffectsManager._instance!=null)
					soundEffectsManager._instance.playWrong();
					Debug.Log ("Result not correct");
					GameManager.instance.tileSelected = false;
				}
			} else Debug.Log("Plant not selected");
		} else Debug.Log ("Tile not selected");

	}


	// Update is called once per frame
	void Update () {
	
	}
}
