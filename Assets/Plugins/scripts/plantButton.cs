using UnityEngine;
using System.Collections;

public class plantButton : MonoBehaviour {

	public Plant carrotScript;
	public Plant turnipScript;

	public void plant(){

		if (GameManager.instance.tileSelected) {
			if(GameManager.instance.plantSelected){
				if(GameManager.instance.correct){
					if(GameManager.instance.getPlantType() == "carrot"){
						//if(soundEffectsManager._instance!=null)
						SoundEffectsManager._instance.playCorrect();
						GameManager.instance.vegtablePlanted = "carrot";
						GameManager.instance.isVegtablePlanted = true;
						carrotScript.callCountDown();
					}
					else if(GameManager.instance.getPlantType() == "turnip"){
						//if(soundEffectsManager._instance!=null)
						SoundEffectsManager._instance.playCorrect();
						GameManager.instance.vegtablePlanted = "turnip";
						GameManager.instance.isVegtablePlanted = true;
						turnipScript.callCountDown();
					}
					else if(GameManager.instance.getPlantType() == "pumpkin"){
						SoundEffectsManager._instance.playCorrect();
						GameManager.instance.vegtablePlanted = "pumpkin";
						GameManager.instance.isVegtablePlanted = true;
					}
					else if(GameManager.instance.getPlantType() == "tomatoes"){
						SoundEffectsManager._instance.playCorrect();
						GameManager.instance.vegtablePlanted = "tomatoes";
						GameManager.instance.isVegtablePlanted = true;
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
