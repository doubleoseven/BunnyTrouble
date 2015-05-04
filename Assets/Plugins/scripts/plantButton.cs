using UnityEngine;
using System.Collections;

public class plantButton : MonoBehaviour {

	public AudioClip wrong;
	public AudioClip correct;

	void Start () {
	}

	public void plant(){

		if (GameManager.instance.tileSelected) {
			if(GameManager.instance.plantSelected){
				if(GameManager.instance.correct){
					if(GameManager.instance.getPlantType() == "carrot"){
						musicPlayer._instance.PlaySingle(correct);
						GameManager.instance.carrotPlanted = true;
					}
					else if(GameManager.instance.getPlantType() == "turnip"){
						musicPlayer._instance.PlaySingle(correct);
						GameManager.instance.turnipPlanted = true;
					}
				} else {
					musicPlayer._instance.PlaySingle(wrong);
					Debug.Log ("Result not correct");
					GameManager.instance.tileSelected = false;
				}
			} else Debug.Log("Plant not selected");
		} else Debug.Log ("Tile not selected");


	}
	// Use this for initialization

	// Update is called once per frame
	void Update () {
	
	}
}
