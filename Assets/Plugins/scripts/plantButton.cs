using UnityEngine;
using System.Collections;

public class plantButton : MonoBehaviour {


	public void plant(){

		if (GameManager.instance.tileSelected) {
			if(GameManager.instance.plantSelected){
				if(GameManager.instance.correct){
					if(GameManager.instance.getPlantType() == "carrot"){
						//if(soundEffectsManager._instance!=null)
						SoundEffectsManager._instance.playCorrect();
						GameManager.instance.vegtablePlanted = "carrot";
					}
					else if(GameManager.instance.getPlantType() == "turnip"){
						//if(soundEffectsManager._instance!=null)
						SoundEffectsManager._instance.playCorrect();
						GameManager.instance.vegtablePlanted = "turnip";
					}
					else if(GameManager.instance.getPlantType() == "pumpkin"){
						SoundEffectsManager._instance.playCorrect();
						GameManager.instance.vegtablePlanted = "pumpkin";
					}
					else if(GameManager.instance.getPlantType() == "tomatoes"){
						SoundEffectsManager._instance.playCorrect();
						GameManager.instance.vegtablePlanted = "tomatoes";
					}
				} else {
					//if(soundEffectsManager._instance!=null)
					SoundEffectsManager._instance.playWrong();
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
